using Entities.Entities;

namespace DataAccess.Interfaces;

public interface IOrderRepository : IGenericRepository<Order>
{
    List<Order> GetOrders(string userId);
}