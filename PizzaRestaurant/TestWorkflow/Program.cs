using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestWorkflow;

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
        Application.Run(ServiceProvider.GetRequiredService<TestWorkflowForm>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        string connectionString = "Server=.;Database=TestPizza2;Trusted_Connection=True;TrustServerCertificate=True;";
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<TestDbContext>(o => o.UseSqlServer(connectionString));
                
                services.AddLogging();
                services.AddWorkflow(); 
                //services.AddWorkflow(x => x.UseSqlServer("Server=.;Database=Workflow;Trusted_Connection=True;TrustServerCertificate=True;", false, true));
                
                services.AddTransient<TestWorkflowForm>();
            });
    }
}