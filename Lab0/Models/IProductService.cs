namespace Lab0.Models;

public interface IProductService
{
    void Add(Product product);
    List<Product> GetAll();
    Product? GetById(int id);
    bool Delete(int id);
    bool Update(Product product);
}