using Microsoft.EntityFrameworkCore;
using Pizzeria.Models.Enums;
using Pizzeria.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Pizzeria.Workflow.Steps;

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
    public string? Message { get; set; }

    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        var product = await DbContext.Products.FirstOrDefaultAsync(x => x.Id == ProductId);
        var courier = await DbContext.Couriers.FirstOrDefaultAsync(x => x.Id == CourierId);
        var rnd = new Random();

        if (courier is null)
        {
            ProductState = ProductState.Failed;
            Success = false;
            Message = "Курьер уволился или не существует";
            MessageBox.Show(Message);
            return ExecutionResult.Next();
        }
        if (product is null)
        {
            ProductState = ProductState.Failed;
            Success = false;
            Message = "Продукт пропал или уничтожен";
            MessageBox.Show(Message);
            return ExecutionResult.Next();
        }
        
        courier.Products.Add(product);
        int time = rnd.Next(5000, 15000);
        ProductState = ProductState.Delivered;
        CourierState = CourierState.Accept;
        await DbService.ChangeProductState(ProductId, ProductState, ClientId, CourierId);
        await DbService.ChangeCourierState(CourierId, CourierState);
        Thread.Sleep(rnd.Next(1000, 3000));
        
        CourierState = CourierState.OnProcess;
        await DbService.ChangeCourierState(CourierId, CourierState);
        Thread.Sleep(time);
        
        CourierState = time > 14000 ? CourierState.Terminated : CourierState.Done;
        await DbService.ChangeCourierState(CourierId, CourierState);
        ProductState = CourierState == CourierState.Terminated ? ProductState.Terminated : ProductState.Completed;
        await DbService.ChangeProductState(ProductId, ProductState, ClientId);
        
        Success = CourierState == CourierState.Done && ProductState == ProductState.Completed;
        Message = Success ? "Продукт успешно доставлен!" : "Время доставки истекло, курьер не справился с задачей, поэтому заказ был отменен";
        
        CourierState = CourierState.Free;
        await DbService.ChangeCourierState(CourierId, CourierState);
        
        return ExecutionResult.Next();
    }
}