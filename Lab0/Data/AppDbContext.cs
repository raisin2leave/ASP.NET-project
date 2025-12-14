using Lab0.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Lab0.Data;

public class AppDbContext : DbContext
{
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<ManufacturerEntity> Manufacturers { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ManufacturerEntity>().HasData(
            new ManufacturerEntity { Id = 1, Name = "Default Manufacturer"},
            new ManufacturerEntity { Id = 2, Name = "Dell",},
            new ManufacturerEntity { Id = 3, Name = "HP" }
        );
        
        modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity
            {
                Id = 1,
                Name = "Laptop",
                Price = 4500,
                ManufacturerId = 2, 
                ProductionDate = new DateTime(2023, 5, 10),
                Description = "Business laptop",
                Category = Models.ProductCategory.Electronics,
                Created = DateTime.Now
            },
            new ProductEntity
            {
                Id = 2,
                Name = "Printer",
                Price = 1200,
                ManufacturerId = 3,
                ProductionDate = new DateTime(2022, 11, 5),
                Description = "Laser printer",
                Category = Models.ProductCategory.Electronics,
                Created = DateTime.Now
            }
        );
        
        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.ManufacturerEntity)
            .WithMany(m => m.Products)
            .HasForeignKey(p => p.ManufacturerId)
            .OnDelete(DeleteBehavior.Restrict); 
    }
}
