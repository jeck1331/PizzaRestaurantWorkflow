using Microsoft.EntityFrameworkCore;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace TestWorkflow.Workflow.TestSteps;

public class Step2 : TestBaseStep
{
    public Step2(TestDbContext dbContext) : base(dbContext) { }
    public int Result { get; set; }
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        var model = await DbContext.Results.FirstOrDefaultAsync(x => x.Result == Result);
        MessageBox.Show($"{model.Title} : Result {model.Result}");
        return ExecutionResult.Next();
    }
}