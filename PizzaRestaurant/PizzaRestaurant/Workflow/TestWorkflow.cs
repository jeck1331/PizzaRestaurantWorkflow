using PizzaRestaurant.Workflow.TestSteps;
using WorkflowCore.Interface;

namespace PizzaRestaurant.Workflow;

public class TestWorkflow : IWorkflow<DataTest>
{
    public void Build(IWorkflowBuilder<DataTest> builder)
    {
        builder
            .StartWith<Step1>()
            .Output(data => data.HelloWorld, step => step.HelloWorld)
            .WaitFor("WaitedEvent", (data, context) => context.Workflow.Id, data => DateTime.Now)
            .Then<Step2>()
            .Input(step => step.HelloWorld, data => data.HelloWorld)
            .EndWorkflow();
    }

    public string Id => "TestWorkflow";
    public int Version => 1;
}