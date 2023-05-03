using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzeriaWorkflow.Mapping;
using PizzeriaWorkflow.Services;
using PizzeriaWorkflow.Workflow;
using PizzeriaWorkflow.Workflow.Steps;
using WorkflowCore.Services;

namespace PizzeriaWorkflow;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var builder = CreateHostBuilder().Build();
        ServiceProvider = builder.Services;

        ApplicationConfiguration.Initialize();
        Application.Run(ServiceProvider.GetRequiredService<PizzeriaForm>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        string connectionString = "Server=.;Database=TestPizza;Trusted_Connection=True;TrustServerCertificate=True;";
        //string workflowConnectionString = "Server=.;Database=WorkflowPizza;Trusted_Connection=True;TrustServerCertificate=True;";
        
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString),
                    contextLifetime: ServiceLifetime.Transient);
                
                services.AddAutoMapper(typeof(WorkflowProfile));
                services.AddLogging();
                services.AddWorkflow();
                //services.AddWorkflow(x => x.UseSqlServer(workflowConnectionString, false, true));

                //Register steps to DI container
                services.AddTransient<OrderStep>();
                services.AddTransient<CookingStep>();
                services.AddTransient<DeliveryStep>();

                services.AddTransient<DBService>();
                services.AddTransient<PizzeriaForm>();
            });
    }
}