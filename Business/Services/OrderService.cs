using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;


    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void Create(Order entity)
    {
        throw new NotImplementedException();
    }

    public List<Order> GetOrders(string userId)
    {
        throw new NotImplementedException();
    }
}