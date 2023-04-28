using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.Steps;

public class CookingStep : BaseStep
{
    public CookingStep(AppDbContext dbContext) : base(dbContext) { }
    public Product Product { get; set; }
    
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        Product.ProductState = Product.ProductState is null ? ProductState.Canceled : ProductState.Ready;
        DbContext.Products.Update(Product);
        await DbContext.SaveChangesAsync();
        return ExecutionResult.Next();
    }
}