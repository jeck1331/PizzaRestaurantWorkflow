using Microsoft.EntityFrameworkCore;
using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;
using PizzaRestaurant.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.Steps;

public class DeliveryStep: BaseStep
{
    public DeliveryStep(AppDbContext dbContext, DBService dbService) : base(dbContext, dbService) { }
    //Input
    public int ProductId { get; set; }
    public int CourierId { get; set; }
    
    //Output
    public ProductState ProductState { get; set; }
    public CourierState CourierState { get; set; }
    public bool Success { get; set; }
    public string? Error { get; set; }

    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        var product = await DbContext.Products.FirstOrDefaultAsync(x => x.Id == ProductId);
        var courier = await DbContext.Couriers.FirstOrDefaultAsync(x => x.Id == CourierId);
        var rnd = new Random();

        if (courier is null)
        {
            ProductState = ProductState.Failed;
            Success = false;
            Error = "Курьер уволился или не существует";
            return ExecutionResult.Next();
        }
        if (product is null)
        {
            ProductState = ProductState.Failed;
            Success = false;
            Error = "Продукт пропал или уничтожен";
            return ExecutionResult.Next();
        }
        courier.Products?.Add(product);
        int time = rnd.Next(5000, 15000);
        ProductState = ProductState.Delivered;
        CourierState = CourierState.Accept;
        await DbService.ChangeProductState(ProductId, ProductState);
        await DbService.ChangeCourierState(CourierId, CourierState);
        Thread.Sleep(rnd.Next(1000, 3000));
        
        CourierState = CourierState.OnProcess;
        await DbService.ChangeCourierState(CourierId, CourierState);
        Thread.Sleep(time);
        
        CourierState = time > 14000 ? CourierState.Terminated : CourierState.Done;
        await DbService.ChangeCourierState(CourierId, CourierState);
        ProductState = CourierState == CourierState.Terminated ? ProductState.Terminated : ProductState.Completed;
        await DbService.ChangeProductState(ProductId, ProductState);
        
        Success = CourierState == CourierState.Done && ProductState == ProductState.Completed;
        Error = Success ? "Продукт успешно доствален!" : "Время доставки истекло, курьер не справился с задачей, поэтому заказ был отменен";
        MessageBox.Show(Error);
        return ExecutionResult.Next();
    }
}