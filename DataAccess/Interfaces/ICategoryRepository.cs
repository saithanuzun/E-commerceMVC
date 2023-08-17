using Entities.Entities;

namespace DataAccess.Interfaces;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Category GetByIdWithProducts(int id);
    void DeleteFromCategory(int categoryId, int productId);
}