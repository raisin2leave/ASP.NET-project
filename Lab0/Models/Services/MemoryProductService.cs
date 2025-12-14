using Lab0.Models.Providers;
using Lab0.Data.Entities;
using Lab0.Models;

namespace Lab0.Models.Services;

public class MemoryProductService : IProductService
{
    private readonly Dictionary<int, Product> _products = new();
    private readonly List<ManufacturerEntity> _manufacturers = new();
    private int _productId = 0;
    private int _manufacturerId = 0;
    private readonly IDateTimeProvider _timeProvider;

    public MemoryProductService(IDateTimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
        _manufacturers.Add(new ManufacturerEntity { Id = ++_manufacturerId, Name = "Dell" });
        _manufacturers.Add(new ManufacturerEntity { Id = ++_manufacturerId, Name = "HP" });
        _manufacturers.Add(new ManufacturerEntity { Id = ++_manufacturerId, Name = "Lenovo" });
    }

    public void Add(Product product)
    {
        product.Id = ++_productId;
        product.Created = _timeProvider.Now();
        _products.Add(product.Id, product);
    }

    public List<Product> GetAll() => _products.Values.ToList();

    public Product? GetById(int id)
        => _products.ContainsKey(id) ? _products[id] : null;

    public bool Delete(int id)
        => _products.Remove(id);

    public bool Update(Product product)
    {
        if (!_products.ContainsKey(product.Id)) return false;
        _products[product.Id] = product;
        return true;
    }

    // NEW: Return all manufacturers for dropdowns
    public List<ManufacturerEntity> GetAllManufacturers()
    {
        return _manufacturers.ToList();
    }
}