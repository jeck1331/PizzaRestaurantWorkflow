using Microsoft.EntityFrameworkCore;
using PizzeriaWorkflow.Models.Enums;
using PizzeriaWorkflow.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzeriaWorkflow.Workflow.Steps;

public class OrderStep : BaseStep
{
    public OrderStep(AppDbContext dbContext, DBService dbService) : base(dbContext, dbService) { }
    
    //Input
    public int OrderProductId { get; set; }

    //Output
    public ProductState ProductState { get; set; }
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        var product = await DbContext.Products.FirstOrDefaultAsync(x => x.Id == OrderProductId);

        if (product is not null)
        {
            ProductState = ProductState.Accept;
            
            await DbService.ChangeProductState(OrderProductId, ProductState, ClientId);
        }
        
        return ExecutionResult.Next();
    }

}