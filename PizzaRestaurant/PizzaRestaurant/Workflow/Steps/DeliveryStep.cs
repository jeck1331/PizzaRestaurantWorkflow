using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.Steps;

public class DeliveryStep: BaseStep
{
    public DeliveryStep(AppDbContext dbContext) : base(dbContext) { }
    public Courier Courier { get; set; }
    public Product Product { get; set; }
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        if (Courier.State == CourierState.Free)
        {
            Courier.State = CourierState.OnProcess;
            Product.ProductState = ProductState.Delivered;
        }
        else
        {
            Courier.State = CourierState.Canceled;
            Product.ProductState = ProductState.Canceled;
        }

        DbContext.Couriers.Update(Courier);
        DbContext.Products.Update(Product);
        await DbContext.SaveChangesAsync();
        return ExecutionResult.Next();
    }
}