using Entities.Entities;

namespace Business.Interfaces;

public interface IOrderService
{
    void Create(Order entity);
    List<Order> GetOrders(string userId);
}