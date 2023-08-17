using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class CategoryRepository : GenericRepository<Category,ShopContext>,ICategoryRepository
{
    public Category GetByIdWithProducts(int id)
    {
        using (var context = new ShopContext())
        {
            return context.Categories
                .Where(i => i.Id == id)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Product)
                .FirstOrDefault();
        }
    }

    public void DeleteFromCategory(int categoryId, int productId)
    {
        throw new NotImplementedException();
    }
}