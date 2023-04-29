using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace TestWorkflow.Workflow.TestSteps;

public class Step1 : TestBaseStep
{
    public Step1(TestDbContext dbContext) : base(dbContext) { }
    public int Input1 { get; set; }
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        MessageBox.Show("Запущено!");
        HelloWorld = "Step 1 EEEEEE";
        DbContext.Results.Add(new TestModel
        {
            Title = HelloWorld,
            Result = Input1
        });
        await DbContext.SaveChangesAsync();
        return ExecutionResult.Next();
    }
}