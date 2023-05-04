using WorkflowCore.Models;

namespace Pizzeria.Models;

public class WorkflowProcess
{
    public int PersistenceId { get; set; }
    public string InstanceId { get; set; }
    public string WorkflowName { get; set; }
    public WorkflowStatus Status { get; set; }
}