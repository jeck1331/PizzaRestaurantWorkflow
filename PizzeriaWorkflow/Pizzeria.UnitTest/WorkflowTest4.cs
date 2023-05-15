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
using Xunit.Abstractions;

namespace Pizzeria.UnitTest;

public class WorkflowTest4 : WorkflowTest<RestaurantWorkflow, DataPizza>
{
    private readonly ITestOutputHelper _testOutputHelper;

    private const string connectionString =
        "Server=.;Database=TestPizza;Trusted_Connection=True;TrustServerCertificate=True;";

    private ServiceProvider? _provider;
    private IMapper _mapper;

    public WorkflowTest4(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
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
    public async Task OrderPizza4()
    {
        using var _dbContext = _provider!.GetRequiredService<AppDbContext>();
        var _dbService = _provider!.GetService<DBService>();

        int _selectedCourierId = 6;
        int _selectedProductId;
        int _selectedClientId = 7;

        var creatingProduct = new Product { Name = "Маргарита" };

        await _dbService.CreateProductAsync(creatingProduct);
        var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
        Assert.NotNull(product);
        _selectedProductId = product.Id;

        var t = new DataPizza
        {
            ClientId = _selectedClientId,
            ProductId = _selectedProductId
        };

        var workflowId = await StartWorkflowAsync(t);

        Thread.Sleep(1000);

        await Host.PublishEvent("EventKitchen", workflowId, ProductState.Accept);

        var productState =
            (await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == _selectedProductId))!
            .ProductState;

        while (productState != ProductState.Terminated || productState != ProductState.Ready)
        {
            Thread.Sleep(2000);
            productState =
                (await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == _selectedProductId))!
                .ProductState;
            if (productState == ProductState.Terminated || productState == ProductState.Ready)
            {
                break;
            }
        }

        Assert.NotNull(productState);

        if (productState == ProductState.Terminated)
        {
            _testOutputHelper.WriteLine($"Товар: {product.Name} просрочен.");
        }
        else
        {
            var courier = await _dbContext.Couriers.FirstOrDefaultAsync(x => x.Id == _selectedCourierId);
            await Host.PublishEvent("EventCourier", workflowId, new EventCourier
            {
                CourierId = courier.Id,
                State = CourierState.Accept
            });

            while (courier.State != CourierState.Done || courier.State != CourierState.Terminated ||
                   courier.State != CourierState.Free)
            {
                Thread.Sleep(2000);
                courier =
                    (await _dbContext.Couriers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == _selectedCourierId))!;

                if (courier.State != CourierState.Done || courier.State != CourierState.Terminated ||
                    courier.State != CourierState.Free)
                {
                    break;
                }
            }

            Assert.NotNull(courier);
            product = await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == product.Id);
            var client = await _dbContext.Clients.AsNoTracking().FirstOrDefaultAsync(x => x.Id == product.ClientId);

            if (courier.State == CourierState.Terminated)
            {
                _testOutputHelper.WriteLine(
                    $"Курьер: {courier.Name} не успел доставить продукт \"{product.Name}\" для клиента \"{client.Name}\".");
            }
            else
            {
                product = await _dbContext.Products.AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Name == creatingProduct.Name);
                courier = await _dbContext.Couriers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == product.CourierId);

                Assert.NotNull(product);
                Assert.NotNull(client);
                Assert.NotNull(courier);

                _testOutputHelper.WriteLine(
                    $"Товар: {product.Name}; Клиент: {client.Name} - id: {client.Id}; Курьер: {courier.Name} - id: {courier.Id}");
            }
        }
    }
}