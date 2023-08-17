using Entities.Entities;

namespace Business.Interfaces;

public interface ICategoryService
{
    Category GetById(int id);
    Category GetByIdWithProducts(int id);
    List<Category> GetAll();
    void Create(Category entity);
    void Update(Category entity);
    void Delete(Category entity);
    void DeleteFromCategory(int categoryId, int productId);
}