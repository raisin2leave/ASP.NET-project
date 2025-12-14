using Lab0.Data.Entities;
using Lab0.Models;

namespace Lab0.Data.Mappers;

public static class ProductMapper
{
    public static Product FromEntity(ProductEntity entity)
    {
        return new Product
        {
            Id = entity.Id,
            Name = entity.Name,
            Price = entity.Price,
            ManufacturerId = entity.ManufacturerId,
            ManufacturerName = entity.ManufacturerEntity?.Name,
            ProductionDate = entity.ProductionDate,
            Description = entity.Description,
            Category = entity.Category,
            Created = entity.Created
        };
    }


    public static ProductEntity ToEntity(Product model)
    {
        return new ProductEntity
        {
            Id = model.Id,
            Name = model.Name,
            Price = model.Price,
            ManufacturerId = model.ManufacturerId,
            ProductionDate = model.ProductionDate,
            Description = model.Description,
            Category = model.Category,
            Created = model.Created
        };
    }
}