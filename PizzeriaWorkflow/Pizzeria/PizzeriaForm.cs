using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Models;
using Pizzeria.Models.DTO;
using Pizzeria.Models.Enums;
using Pizzeria.Services;
using Pizzeria.Workflow;
using WorkflowCore.Interface;
using WorkflowCore.Models;
using WorkflowCore.Persistence.EntityFramework.Services;
using WorkflowCore.Persistence.SqlServer;

namespace Pizzeria;

public partial class PizzeriaForm : Form
{
    private readonly AppDbContext _dbContext;
    private readonly IWorkflowHost _workflowHost;
    private readonly DBService _dbService;
    private readonly IMapper _mapper;

    private string _currentWorkflowId = "RestaurantWorkflow";
    private string _workflowId = "";
    private int? _selectedCourierId = null;
    private int? _selectedProductId = null;
    private int? _selectedClientId = null;

    public PizzeriaForm(AppDbContext dbContext, DBService dbService, IServiceProvider serviceProvider, IMapper mapper)
    {
        _workflowHost = serviceProvider.GetService<IWorkflowHost>();
        _workflowHost?.RegisterWorkflow<RestaurantWorkflow, DataPizza>();
        _workflowHost.Start();

        _dbContext = dbContext;
        _dbService = dbService;
        _mapper = mapper;

        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        RefreshData();
    }

    private async void btnAddClient_Click(object sender, EventArgs e)
    {
        await _dbService.CreateClientAsync(new Client { Name = tbNameClient.Text });
        RefreshData();
    }

    private async Task RunWorkflowAsync(DataPizza t)
    {
        await Task.Run(() =>
        {
            _workflowId = _workflowHost.StartWorkflow(_currentWorkflowId, t).Result;
        });
        lblWorkflowId.Text = _workflowId;
        await _dbService.AddNewWorkflow(new WorkflowProcess { InstanceId = _workflowId, WorkflowName = _currentWorkflowId, Status = WorkflowStatus.Runnable });
        RefreshData();
    }

    private async void btnAddProduct_Click(object sender, EventArgs e)
    {
        if (_selectedClientId != null)
        {
            await _dbService.CreateProductAsync(new Product { Name = tbNameProduct.Text });
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == tbNameProduct.Text);
            RefreshData();
            if (product is not null)
            {
                var t = new DataPizza
                {
                    ClientId = _selectedClientId ?? 0,
                    ProductId = product.Id
                };
                await RunWorkflowAsync(t);
            }
        }
    }

    private async void btnAddCourier_Click(object sender, EventArgs e)
    {
        await _dbService.CreateCourierAsync(new Courier { Name = tbNameCourier.Text, State = CourierState.Free });
        RefreshData();
    }

    private void btnClientView_Click(object sender, EventArgs e)
    {
        //VisibleDataGrid(ViewDataGrid.Clients);
    }

    private void btnCouriersView_Click(object sender, EventArgs e)
    {
        //VisibleDataGrid(ViewDataGrid.Couriers);
    }

    private void btnProductsView_Click(object sender, EventArgs e)
    {
        //(ViewDataGrid.Products);
    }

    private void btnAddEntries_Click(object sender, EventArgs e)
    {
        VisibleStates(false);
    }

    private void btnChangeStates_Click(object sender, EventArgs e)
    {
        VisibleStates(true);
    }

    //Продукты
    private async void btnAcceptProd_Click(object sender, EventArgs e)
    {
        await _workflowHost.PublishEvent("EventKitchen", _workflowId, ProductState.Accept);
        RefreshData();
    }

    //Курьеры
    private async void btnAcceptCor_Click(object sender, EventArgs e)
    {
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
        await _workflowHost.PublishEvent("EventCourier", _workflowId, new EventCourier
        {
            CourierId = courier.Id,
            State = CourierState.Accept
        });
        RefreshData();
    }

    void VisibleDataGrid(ViewDataGrid state)
    {
        switch (state)
        {
            case ViewDataGrid.Clients:
                dataClients.Visible = true;
                dataCouriers.Visible = false;
                dataProducts.Visible = false;
                break;
            case ViewDataGrid.Products:
                dataClients.Visible = false;
                dataCouriers.Visible = false;
                dataProducts.Visible = true;
                break;
            case ViewDataGrid.Couriers:
                dataClients.Visible = false;
                dataCouriers.Visible = true;
                dataProducts.Visible = false;
                break;
            default:
                dataClients.Visible = true;
                dataCouriers.Visible = false;
                dataProducts.Visible = false;
                break;
        }
    }

    void VisibleStates(bool visible)
    {
        boxClientAdd.Visible = !visible;
        boxCourierAdd.Visible = !visible;
        boxProductAdd.Visible = !visible;

        boxCouriersState.Visible = visible;
        boxKithcenState.Visible = visible;
    }

    void DeleteBtnsEnabled()
    {
        btnDelCourier.Enabled = _selectedCourierId != null;
        btnDelClient.Enabled = _selectedClientId != null;
        btnDelProduct.Enabled = _selectedProductId != null;

        lbClient.Text = _selectedClientId == null ? "" : _selectedClientId.ToString();
        lbCourier.Text = _selectedCourierId == null ? "" : _selectedCourierId.ToString();
        lbProduct.Text = _selectedProductId == null ? "" : _selectedProductId.ToString();
    }
    private void dataCouriers_MouseClick(object sender, MouseEventArgs e)
    {
        var courier = (CourierDTO)dataCouriers.CurrentRow.DataBoundItem;
        _selectedCourierId = courier.Id;
        DeleteBtnsEnabled();
        tbNumCourier.Text = courier.Id.ToString();
    }

    private void dataProducts_MouseClick(object sender, MouseEventArgs e)
    {
        var product = (ProductDTO)dataProducts.CurrentRow.DataBoundItem;
        _selectedProductId = product.Id;
        DeleteBtnsEnabled();
        tbNumProd.Text = product.Id.ToString();
    }

    private void dataClients_MouseClick(object sender, MouseEventArgs e)
    {
        var client = (ClientDTO)dataClients.CurrentRow.DataBoundItem;
        _selectedClientId = client.Id;
        DeleteBtnsEnabled();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshData();
    }

    async void RefreshData()
    {
        var couriers = await _dbService.Couriers();
        var products = await _dbService.Products();
        var clients = await _dbService.Clients();
        var workflows = await _dbService.GetRunningInstances();

        dataCouriers.DataSource = _mapper.Map<List<CourierDTO>>(couriers);
        dataProducts.DataSource = _mapper.Map<List<ProductDTO>>(products);
        dataClients.DataSource = _mapper.Map<List<ClientDTO>>(clients);
        dgvWorkflowsRunning.DataSource = workflows;
    }

    private async void btnDelClient_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteClientAsync(_selectedClientId ?? 0);
        _selectedClientId = null;
        DeleteBtnsEnabled();
        RefreshData();
    }

    private async void btnDelProduct_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteProductAsync(_selectedProductId ?? 0);
        _selectedProductId = null;
        DeleteBtnsEnabled();
        RefreshData();
    }

    private async void btnDelCourier_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteCourierAsync(_selectedCourierId ?? 0);
        _selectedCourierId = null;
        DeleteBtnsEnabled();
        RefreshData();
    }

    private async void btnCancelKitchen_Click(object sender, EventArgs e)
    {
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == _selectedProductId);
        await _workflowHost.PublishEvent("EventKitchen", _workflowId, ProductState.Canceled);
        await _dbService.ChangeProductState(product!.Id, ProductState.Canceled, _selectedClientId!.Value);
        RefreshData();
    }

    private async void btnCancelCourier_Click(object sender, EventArgs e)
    {
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
        await _workflowHost.PublishEvent("EventCourier", _workflowId, new EventCourier
        {
            CourierId = courier?.Id,
            State = CourierState.Canceled
        });
        await _dbService.ChangeCourierState(courier!.Id, CourierState.Canceled);
        RefreshData();
    }

    private async void btnStatus_Click(object sender, EventArgs e)
    {
        if (dgvWorkflowsRunning.CurrentRow is not null)
        {
            var workflow = (WorkflowProcess)dgvWorkflowsRunning.CurrentRow.DataBoundItem;
            _workflowId = workflow.InstanceId;
            lblWorkflowId.Text = _workflowId;
        }

        var t = await _workflowHost.PersistenceStore.GetRunnableInstances(new DateTime(2023,5,5));
        var t1 = t.ToList();

        var s = await _workflowHost.PersistenceStore.GetWorkflowInstance(_workflowId);
    }

    private void PizzeriaForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }
}