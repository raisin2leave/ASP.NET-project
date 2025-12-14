using Lab0.Data.Entities;

namespace Lab0.Models.Services;

public interface IProductService
{
    void Add(Product product);
    List<Product> GetAll();
    Product? GetById(int id);
    bool Delete(int id);
    bool Update(Product product);
    List<ManufacturerEntity> GetAllManufacturers();
}