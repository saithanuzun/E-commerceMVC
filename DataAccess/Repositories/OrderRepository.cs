using DataAccess.Context;
using DataAccess.Interfaces;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories;

public class OrderRepository : GenericRepository<Order, ShopContext>, IOrderRepository
{
    public List<Order> GetOrders(string userId)
    {
        using (var context = new ShopContext())
        {
            var orders = context.Orders
                .Include(i => i.OrderItems)
                .ThenInclude(i => i.Product)
                .AsQueryable();

            if (!string.IsNullOrEmpty(userId))
            {
                orders = orders.Where(i => i.UserId == userId);
            }

            return orders.ToList();
        }
    }
}