using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;
using PizzaRestaurant.Services;
using PizzaRestaurant.Workflow;
using WorkflowCore.Interface;

namespace PizzaRestaurant;

public partial class Form1 : Form
{
    private readonly AppDbContext _dbContext;
    private readonly IWorkflowHost _workflowHost;
    private readonly DBService _dbService;

    private string _currentWorkflowId = "RestaurantWorkflow";
    private string _workflowId = "";
    private int? _selectedCourierId = null;
    private int? _selectedProductId = null;
    private int? _selectedClientId = null;

    public Form1(AppDbContext dbContext, DBService dbService, IServiceProvider serviceProvider)
    {
        var workflowHost = serviceProvider.GetService<IWorkflowHost>();
        workflowHost?.RegisterWorkflow<RestaurantWorkflow, DataPizza>();
        //workflowHost?.RegisterWorkflow<TestWorkflow, DataTest>();
        workflowHost.Start();
        InitializeComponent();
        _dbContext = dbContext;
        _dbService = dbService;
        _workflowHost = serviceProvider.GetService<IWorkflowHost>()!;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        dataClients.DataSource = _dbContext.Clients.ToList();
        dataCouriers.DataSource = _dbContext.Couriers.ToList();
        dataProducts.DataSource = _dbContext.Products.ToList();
    }

    private async void btnAddClient_Click(object sender, EventArgs e)
    {
        await _dbService.CreateClientAsync(new Client { Name = tbNameClient.Text });
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
                _workflowId = _workflowHost.StartWorkflow(_currentWorkflowId, t).Result;
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
        VisibleDataGrid(ViewDataGrid.Clients);
    }

    private void btnCouriersView_Click(object sender, EventArgs e)
    {
        VisibleDataGrid(ViewDataGrid.Couriers);
    }

    private void btnProductsView_Click(object sender, EventArgs e)
    {
        VisibleDataGrid(ViewDataGrid.Products);
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
        await _workflowHost.PublishEvent("AcceptKitchen", _workflowId, null);
        RefreshData();
    }

    private void btnCancelProd_Click(object sender, EventArgs e)
    {
    }

    private void btnBeginProd_Click(object sender, EventArgs e)
    {
    }

    private async void btnDoneProd_Click(object sender, EventArgs e)
    {
    }

    private void btnTermProd_Click(object sender, EventArgs e)
    {
    }

    //Курьеры
    private async void btnAcceptCor_Click(object sender, EventArgs e)
    {
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
        await _workflowHost.PublishEvent("AcceptCourier", _workflowId, courier?.Id);
        RefreshData();
    }

    private void btnCancelCor_Click(object sender, EventArgs e)
    {
    }

    private void btnBeginCor_Click(object sender, EventArgs e)
    {
    }

    private void btnDeliverCor_Click(object sender, EventArgs e)
    {
    }

    private void btnTermCor_Click(object sender, EventArgs e)
    {
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
    private void dataCouriers_MouseClick(object sender, MouseEventArgs e)
    {
        var courier = (Courier)dataCouriers.CurrentRow.DataBoundItem;
        _selectedCourierId = courier.Id;
        btnDelCourier.Enabled = true;
        tbNumCourier.Text = courier.Id.ToString();
        lbCourier.Text = courier.Id.ToString();
    }

    private void dataProducts_MouseClick(object sender, MouseEventArgs e)
    {
        var product = (Product)dataProducts.CurrentRow.DataBoundItem;
        _selectedProductId = product.Id;
        btnDelProduct.Enabled = true;
        tbNumProd.Text = product.Id.ToString();
        lbProduct.Text = product.Id.ToString();
    }

    private void dataClients_MouseClick(object sender, MouseEventArgs e)
    {
        var client = (Client)dataClients.CurrentRow.DataBoundItem;
        _selectedClientId = client.Id;
        btnDelClient.Enabled = true;
        lbClient.Text = client.Id.ToString();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        RefreshData();
    }

    async void RefreshData()
    {
        dataCouriers.DataSource = await _dbContext.Couriers.ToListAsync();
        dataProducts.DataSource = await _dbContext.Products.ToListAsync();
        dataClients.DataSource = await _dbContext.Clients.ToListAsync();
    }

    private void form_Closing(object sender, EventArgs e)
    {
        // _workflowHost.Stop();
    }

    private async void btnDelClient_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteClientAsync(_selectedClientId ?? 0);
        RefreshData();
    }

    private async void btnDelProduct_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteProductAsync(_selectedProductId ?? 0);
        RefreshData();
    }

    private async void btnDelCourier_Click(object sender, EventArgs e)
    {
        await _dbService.DeleteCourierAsync(_selectedCourierId ?? 0);
        RefreshData();
    }
}