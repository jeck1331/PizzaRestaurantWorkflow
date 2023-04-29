using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.TestSteps;

public class Step1 : TestBaseStep
{
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        HelloWorld = "Step 1 EEEEEE";
        return ExecutionResult.Next();
    }
}