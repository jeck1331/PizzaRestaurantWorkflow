using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.Mapping;
using Pizzeria.Models;
using Pizzeria.Models.Enums;
using Pizzeria.Services;
using Pizzeria.Workflow;
using Pizzeria.Workflow.Steps;
using WorkflowCore.Testing;

namespace Pizzeria.UnitTest;

public sealed class WorkflowTest : WorkflowTest<RestaurantWorkflow, DataPizza>
{
    private const string connectionString = "Server=.;Database=TestPizza;Trusted_Connection=True;TrustServerCertificate=True;";
    private ServiceProvider? _provider;
    private IMapper _mapper;
    
    public WorkflowTest()
    {
        Setup();
    }

    protected override void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString),
            contextLifetime: ServiceLifetime.Transient);
                
        services.AddAutoMapper(typeof(WorkflowProfile));
        services.AddLogging();
        services.AddWorkflow();
        //services.AddWorkflow(x => x.UseSqlServer(workflowConnectionString, false, true));

        //Register steps to DI container
        services.AddTransient<OrderStep>();
        services.AddTransient<CookingStep>();
        services.AddTransient<DeliveryStep>();

        services.AddTransient<DBService>();
        services.AddTransient<PizzeriaForm>();
        
        _provider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task OrderPizza()
    {
        using var _dbContext = _provider!.GetRequiredService<AppDbContext>();
        using var _dbService = _provider.GetService<DBService>();

        int? _selectedCourierId = 2;
        int? _selectedProductId = null;
        int? _selectedClientId = 1;

        var creatingProduct = new Product { Name = "Пепперони" };

        await _dbService.CreateProductAsync(creatingProduct);
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
        _selectedProductId = product.Id;
        
        var t = new DataPizza
        {
            ClientId = _selectedClientId ?? 0,
            ProductId = product.Id
        };
        
        var workflowId = StartWorkflow(t);
        
        await _workflowHost.PublishEvent("EventKitchen", workflowId, ProductState.Accept);
        
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
        await _workflowHost.PublishEvent("EventCourier", workflowId, new EventCourier
        {
            CourierId = courier.Id,
            State = CourierState.Accept
        });
        
        product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
        var client = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == product.ClientId);
        courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == product.CourierId);
        
        Console.WriteLine($"Товар: {product.Name}; Клиент: {client.Name} - id: {client.Id}; Курьер: {courier.Name} - id: {courier.Id}");
    }
    
    [Fact]
    public async Task OrderPizza1()
    {
        int? _selectedCourierId = 2;
        int? _selectedProductId = null;
        int? _selectedClientId = 2;

        var creatingProduct = new Product { Name = "Мясная" };

        await _dbService.CreateProductAsync(creatingProduct);
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
        _selectedProductId = product.Id;
        
        var t = new DataPizza
        {
            ClientId = _selectedClientId ?? 0,
            ProductId = product.Id
        };
        
        var workflowId = StartWorkflow(t);
        
        await _workflowHost.PublishEvent("EventKitchen", workflowId, ProductState.Accept);
        
        var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
        await _workflowHost.PublishEvent("EventCourier", workflowId, new EventCourier
        {
            CourierId = courier.Id,
            State = CourierState.Accept
        });
        
        product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
        var client = await _dbContext.Clients.FirstOrDefaultAsync(x => x.Id == product.ClientId);
        courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == product.CourierId);
        
        Console.WriteLine($"Товар: {product.Name}; Клиент: {client.Name} - id: {client.Id}; Курьер: {courier.Name} - id: {courier.Id}");
    }
}