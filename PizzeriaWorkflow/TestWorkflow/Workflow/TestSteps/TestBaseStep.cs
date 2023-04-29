using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace TestWorkflow.Workflow.TestSteps;

public abstract class TestBaseStep : IStepBody
{
    private TestDbContext _dbContext;

    public TestBaseStep(TestDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected TestDbContext DbContext => _dbContext;

    public string HelloWorld { get; set; }
    public abstract Task<ExecutionResult> RunAsync(IStepExecutionContext context);
}