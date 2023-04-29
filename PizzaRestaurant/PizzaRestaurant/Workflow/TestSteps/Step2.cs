using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow.TestSteps;

public class Step2 : TestBaseStep
{
    public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        MessageBox.Show(HelloWorld);
        return ExecutionResult.Next();
    }
}