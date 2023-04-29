using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaRestaurant.Services;

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
                services.AddDbContext<AppDbContext>(o => o.UseSqlServer(connectionString));
                
                services.AddTransient<DBService>();
                services.AddTransient<Form1>();
                
                services.AddLogging();
                services.AddWorkflow();
                //services.AddWorkflow(x => x.UseSqlServer(connectionString, false, true));
            });
    }
}