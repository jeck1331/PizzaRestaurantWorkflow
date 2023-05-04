using Pizzeria.Services;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Pizzeria.Workflow;

public abstract class BaseStep : IStepBody
{
    private readonly AppDbContext _dbContext;
    private readonly DBService _dbService;

    public BaseStep(AppDbContext dbContext, DBService dbService)
    {
        _dbContext = dbContext;
        _dbService = dbService;
    }
    
    protected AppDbContext DbContext => _dbContext;
    protected DBService DbService => _dbService;
    
    //Input
    public int ClientId { get; set; }
    
    public abstract Task<ExecutionResult> RunAsync(IStepExecutionContext context);
}