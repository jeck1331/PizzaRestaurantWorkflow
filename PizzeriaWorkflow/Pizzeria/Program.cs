using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzeria.Mapping;
using Pizzeria.Services;
using Pizzeria.Workflow.Steps;
using WorkflowCore.Persistence.EntityFramework.Services;
using WorkflowCore.Services;

namespace Pizzeria;

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
        string workflowConnectionString = "Server=.;Database=WorkflowPizza;Trusted_Connection=True;";
        
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString),
                        contextLifetime: ServiceLifetime.Transient);
                
                services.AddAutoMapper(typeof(WorkflowProfile));
                services.AddLogging();
                //services.AddWorkflow();
                services.AddWorkflow(x => x.UseSqlServer(workflowConnectionString, false, false));

                //Register steps to DI container
                services.AddTransient<OrderStep>();
                services.AddTransient<CookingStep>();
                services.AddTransient<DeliveryStep>();
                services.AddTransient<EndStep>();

                services.AddTransient<DBService>();
                services.AddTransient<PizzeriaForm>();
            });
    }
}