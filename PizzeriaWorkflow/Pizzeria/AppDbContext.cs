using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;

namespace Pizzeria;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Client> Clients { get; set; } = null!;
    public DbSet<Courier> Couriers { get; set; } = null!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        //Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ConfigureModel(modelBuilder);
    }

    private void ConfigureModel(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Courier>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<Product>()
            .HasKey(x => x.Id);
        modelBuilder.Entity<Product>()
            .HasOne(x => x.Client)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.ClientId);
        modelBuilder.Entity<Product>()
            .HasOne(x => x.Courier)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CourierId);
    }
}