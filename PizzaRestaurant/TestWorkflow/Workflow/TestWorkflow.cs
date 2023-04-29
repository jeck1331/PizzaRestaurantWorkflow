using TestWorkflow.Workflow.TestSteps;
using WorkflowCore.Interface;

namespace TestWorkflow.Workflow;

public class TestWorkflow : IWorkflow<DataTest>
{
    public void Build(IWorkflowBuilder<DataTest> builder)
    {
        builder
            .StartWith<Step1>()
            .Input(step => step.Input1, data => data.Result)
            .Output(data => data.Result, step => step.Input1)
            .Output(data => data.HelloWorld, step => step.HelloWorld)
            .WaitFor("WaitedEvent", (data, context) => context.Workflow.Id, data => DateTime.Now)
            .Then<Step2>()
            .Input(step => step.HelloWorld, data => data.HelloWorld)
            .Input(step => step.Result, data => data.Result)
            .EndWorkflow();
    }

    public string Id => "TestWorkflow";
    public int Version => 1;
}