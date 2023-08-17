using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetByIdWithCategories(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetProductDetails(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsByCategory(string category, int page, int pageSize)
    {
        throw new NotImplementedException();
    }

    public int GetCountByCategory(string category)
    {
        throw new NotImplementedException();
    }

    public bool Create(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity, int[] categoryIds)
    {
        throw new NotImplementedException();
    }
}