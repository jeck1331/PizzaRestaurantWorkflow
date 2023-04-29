using Microsoft.Extensions.DependencyInjection;
using TestWorkflow.Workflow;
using WorkflowCore.Interface;

namespace TestWorkflow;

public partial class TestWorkflowForm : Form
{
    private readonly IWorkflowHost _workflowHost;

    private string _currentWorkflowId = "TestWorkflow";
    private string _workflowId = "";

    public TestWorkflowForm(IServiceProvider serviceProvider)
    {
        var workflowHost = serviceProvider.GetService<IWorkflowHost>();
        workflowHost.RegisterWorkflow<TestWorkflowDbContext, DataTest>();
        workflowHost.Start();
        InitializeComponent();
        _workflowHost = serviceProvider.GetService<IWorkflowHost>()!;
    }
    private async void btnEvent_Click(object sender, EventArgs e)
    {
        await _workflowHost.PublishEvent("WaitedEvent", _workflowId, null);
    }
    
    private async void btnStart_Click(object sender, EventArgs e)
    {
        var rnd = new Random();
        _workflowId = await _workflowHost.StartWorkflow(_currentWorkflowId, new DataTest
        {
            HelloWorld = "Hello",
            Result = rnd.Next(1, 1200)
        });
    }
}