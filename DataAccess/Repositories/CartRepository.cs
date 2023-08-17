using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class CartRepository : GenericRepository<Cart, ShopContext>, ICartRepository
{
    public Cart? GetByUserId(string userId)
    {
        using (var context = new ShopContext())
        {
            return context
                .Carts
                .Include(i => i.CartItems)
                .ThenInclude(i => i.Product)
                .FirstOrDefault(i => i.UserId == userId);
        }
    }

    public void DeleteFromCart(int cartId, int productId)
    {
        
    }

    public void ClearCart(string cartId)
    {
        throw new NotImplementedException();
    }
}