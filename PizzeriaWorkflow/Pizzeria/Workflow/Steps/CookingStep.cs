using Microsoft.EntityFrameworkCore;
using Pizzeria.Models.Enums;
using Pizzeria.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Pizzeria.Workflow.Steps;

public class CookingStep : BaseStep
{
    public CookingStep(AppDbContext dbContext, DBService dbService) : base(dbContext, dbService) { }
    
    //Input
    public int ProductId { get; set; }
    
    //Output
    public ProductState ProductState { get; set; }

    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        var product = await DbContext.Products.FirstOrDefaultAsync(x => x.Id == ProductId);
        var rnd = new Random();

        if (product is not null)
        {
            int time = rnd.Next(5000, 15000);
            await DbService.ChangeProductState(ProductId, ProductState.GettingReady, ClientId);
            
            Thread.Sleep(time);
            
            ProductState = time > 12000 ? ProductState.Terminated : ProductState.Ready;
            
            await DbService.ChangeProductState(ProductId, ProductState, ClientId);
        }
        return ExecutionResult.Next();
    }
}