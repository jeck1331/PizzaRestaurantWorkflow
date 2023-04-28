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

    private string _currentWorkflowId = "";

    public Form1(AppDbContext dbContext, DBService dbService, IServiceProvider serviceProvider)
    {
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
        dataClients.DataSource = await _dbContext.Clients.ToListAsync();
    }

    private async void btnAddProduct_Click(object sender, EventArgs e)
    {
        var product = new Product { Name = tbNameProduct.Text, ProductState = ProductState.NotAccept };
        await _dbService.CreateProductAsync(product);
        dataProducts.DataSource = await _dbContext.Products.ToListAsync();

        _currentWorkflowId = "RestaurantPizza";
        await _workflowHost.StartWorkflow(_currentWorkflowId, new DataPizza
        {
            Product = product
        });
    }

    private async void btnAddCourier_Click(object sender, EventArgs e)
    {
        await _dbService.CreateCourierAsync(new Courier { Name = tbNameCourier.Text, State = CourierState.Free });
        dataCouriers.DataSource = await _dbContext.Couriers.ToListAsync();
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
    private void btnAcceptProd_Click(object sender, EventArgs e)
    {
    }

    private void btnCancelProd_Click(object sender, EventArgs e)
    {
    }

    private void btnBeginProd_Click(object sender, EventArgs e)
    {
    }

    private async void btnDoneProd_Click(object sender, EventArgs e)
    {
        var productId = Convert.ToInt32(tbNumProd.Text);
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
        await _workflowHost.PublishEvent("CookingReady", _currentWorkflowId, product);
    }

    private void btnTermProd_Click(object sender, EventArgs e)
    {
    }

    //Курьеры
    private async void btnAcceptCor_Click(object sender, EventArgs e)
    {
        var courierId = Convert.ToInt32(tbNumCourier.Text);
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == courierId);
        await _workflowHost.PublishEvent("CourierAccept", _currentWorkflowId, courier);
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

    void StopWorkflow()
    {
        _workflowHost.Stop();
    }
    void ResumeWorkflow()
    {
        _workflowHost.ResumeWorkflow(_currentWorkflowId);
    }

    private void dataCouriers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        var courier = (Courier)dataCouriers.CurrentRow.DataBoundItem;
        tbNumCourier.Text = courier.Id.ToString();
    }

    private void dataProducts_SelectionChanged(object sender, EventArgs e)
    {
        var product = (Product)dataProducts.CurrentRow.DataBoundItem;
        tbNumProd.Text = product.Id.ToString();
    }

    private void dataCouriers_MouseClick(object sender, MouseEventArgs e)
    {
        var courier = (Courier)dataCouriers.CurrentRow.DataBoundItem;
        tbNumCourier.Text = courier.Id.ToString();
    }

    private void dataProducts_MouseClick(object sender, MouseEventArgs e)
    {
        var product = (Product)dataProducts.CurrentRow.DataBoundItem;
        tbNumProd.Text = product.Id.ToString();
    }
}