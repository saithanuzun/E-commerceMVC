using Entities.Entities;

namespace Business.Interfaces;

public interface IProductService
{
    Product GetById(int id);
    Product GetByIdWithCategories(int id);
    Product GetProductDetails(int id);
    List<Product> GetAll();
    List<Product> GetProductsByCategory(string category, int page, int pageSize);
    int GetCountByCategory(string category);
    bool Create(Product entity);
    void Update(Product entity);
    void Delete(Product entity);
    void Update(Product entity, int[] categoryIds);
}