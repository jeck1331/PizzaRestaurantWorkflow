using Pizzeria.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Pizzeria.Workflow.Steps;

public class EndStep : BaseStep
{
    public EndStep(AppDbContext dbContext, DBService dbService) : base(dbContext, dbService) { }

    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        await DbService.ChangeWorkflowInstanceStatus(context.Workflow.Id, context.Workflow.Status != WorkflowStatus.Runnable ? context.Workflow.Status : WorkflowStatus.Complete);
        return ExecutionResult.Next();
    }
}