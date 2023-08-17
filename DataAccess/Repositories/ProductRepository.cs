using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class ProductRepository : GenericRepository<Product,ShopContext>, IProductRepository
{
    public List<Product> GetProductsByCategory(string category, int page, int pageSize)
    {
        using (var context = new ShopContext())
        {
            var products = context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
            }

            return products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
    }

    public Product GetProductDetails(int id)
    {
        using (var context = new ShopContext())
        {
            return context.Products
                .Where(i => i.Id == id)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefault();
        }
    }

    public int GetCountByCategory(string category)
    {
        using (var context = new ShopContext())
        {
            var products = context.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.Name.ToLower() == category.ToLower()));
            }

            return products.Count();
        }
    }

    public Product GetByIdWithCategories(int id)
    {
        using (var context = new ShopContext())
        {
            return context.Products
                .Where(i => i.Id == id)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category)
                .FirstOrDefault();
        }
    }

    public void Update(Product entity, int[] categoryIds)
    {
        using (var context = new ShopContext())
        {
            var product = context.Products
                .Include(i => i.ProductCategories)
                .FirstOrDefault(i => i.Id == entity.Id);

            if (product != null)
            {
                product.Name = entity.Name;
                product.Description = entity.Description;
                product.ImageUrl = entity.ImageUrl;
                product.Price = entity.Price;

                product.ProductCategories = categoryIds.Select(catid => new ProductCategory()
                {
                    CategoryId = catid,
                    ProductId = entity.Id
                }).ToList();

                context.SaveChanges();
            }
        }
    }
}