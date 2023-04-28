using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace PizzaRestaurant.Workflow;

public class BaseStep : IStepBody
{
    private readonly AppDbContext _dbContext;

    public BaseStep(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    protected AppDbContext DbContext => _dbContext;
    public virtual async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
    {
        return ExecutionResult.Next();
    }
}