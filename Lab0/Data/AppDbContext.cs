using Lab0.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab0.Data;

public class AppDbContext : DbContext
{
    public DbSet<ProductEntity> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity
            {
                Id = 1,
                Name = "Laptop",
                Price = 4500,
                Manufacturer = "Dell",
                ProductionDate = new DateTime(2023, 5, 10),
                Description = "Business laptop"
            }
        );
    }
}