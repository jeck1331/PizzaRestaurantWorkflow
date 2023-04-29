using Microsoft.EntityFrameworkCore;

namespace TestWorkflow;

public class TestDbContext: DbContext
{
    public DbSet<TestModel> Results { get; set; } = null!;

    public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
    {
        //Database.Migrate();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TestModel>()
            .HasKey(x => x.Id);
    }
}