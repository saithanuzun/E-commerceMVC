using Entities.Entities;

namespace DataAccess.Interfaces;

public interface IProductRepository  : IGenericRepository<Product>
{
    List<Product> GetProductsByCategory(string category, int page, int pageSize);

    Product GetProductDetails(int id);

    int GetCountByCategory(string category);
    Product GetByIdWithCategories(int id);
    void Update(Product entity, int[] categoryIds);
}