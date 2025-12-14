using Lab0.Models.Providers;

namespace Lab0.Models.Services;

public class MemoryProductService : IProductService
{
    private readonly Dictionary<int, Product> _products = new();
    private int _id = 0;
    private readonly IDateTimeProvider _timeProvider;

    public MemoryProductService(IDateTimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }

    public void Add(Product product)
    {
        product.Id = ++_id;
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
}