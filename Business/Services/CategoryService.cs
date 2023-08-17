using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Category GetByIdWithProducts(int id)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Create(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteFromCategory(int categoryId, int productId)
    {
        throw new NotImplementedException();
    }
}