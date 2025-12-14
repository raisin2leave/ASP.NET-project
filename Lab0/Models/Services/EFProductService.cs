using Lab0.Data;
using Lab0.Data.Entities;
using Lab0.Data.Mappers;
using Lab0.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab0.Models.Services;

public class EFProductService : IProductService
{
    private readonly AppDbContext _context;

    public EFProductService(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Product product)
    {
        var entity = ProductMapper.ToEntity(product);
        entity.Created = DateTime.Now; // Set creation time
        _context.Products.Add(entity);
        _context.SaveChanges();
        product.Id = entity.Id;
    }

    public List<Product> GetAll()
    {
        return _context.Products
            .AsNoTracking()
            .Select(ProductMapper.FromEntity)
            .ToList();
    }

    public Product? GetById(int id)
    {
        var entity = _context.Products.Find(id);
        return entity is null ? null : ProductMapper.FromEntity(entity);
    }

    public bool Delete(int id)
    {
        var entity = _context.Products.Find(id);
        if (entity == null) return false;

        _context.Products.Remove(entity);
        _context.SaveChanges();
        return true;
    }

    public bool Update(Product product)
    {
        var entity = _context.Products.Find(product.Id);
        if (entity == null) return false;
        
        entity.Name = product.Name;
        entity.Price = product.Price;
        entity.Manufacturer = product.Manufacturer;
        entity.ProductionDate = product.ProductionDate;
        entity.Description = product.Description;
        entity.Category = product.Category;

        _context.Products.Update(entity);
        _context.SaveChanges();
        return true;
    }
}