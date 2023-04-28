using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaRestaurant.Services;
using PizzaRestaurant.Workflow;
using WorkflowCore.Interface;

namespace PizzaRestaurant;

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
        var workflowHost = ServiceProvider.GetService<IWorkflowHost>();
        workflowHost.RegisterWorkflow<RestaurantWorkflow, DataPizza>();
        workflowHost.Start();

        Console.WriteLine("Starting workflow pizza...");

        ApplicationConfiguration.Initialize();
        Application.Run(ServiceProvider.GetRequiredService<Form1>());
    }

    public static IServiceProvider ServiceProvider { get; private set; }

    static IHostBuilder CreateHostBuilder()
    {
        string connectionString = "Server=.;Database=TestPizza;Trusted_Connection=True;TrustServerCertificate=True;";
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddScoped<DBService>();
                services.AddScoped<Form1>();
                services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));
                services.AddLogging();
                services.AddWorkflow(x => x.UseSqlServer(connectionString, true, true));
            });
    }
}