using PizzaRestaurant.Models;
using PizzaRestaurant.Models.Enums;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.Steps;

public class OrderStep : BaseStep
{
    public OrderStep(AppDbContext dbContext) : base(dbContext) { }
    public Product InitProduct { get; set; }
    public Client Client { get; set; }
    public async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        MessageBox.Show("Пицца заказана!");
        InitProduct.ProductState = ProductState.Accept;
        DbContext.Products.Update(InitProduct);
        await DbContext.SaveChangesAsync();
        return ExecutionResult.Next();
    }

}