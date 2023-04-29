using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.TestSteps;

public abstract class TestBaseStep : IStepBody
{
    public string HelloWorld { get; set; }
    public abstract Task<ExecutionResult> RunAsync(IStepExecutionContext context);
}