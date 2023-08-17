using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;

namespace Business.Services;

public class CartService : ICartService
{
    private readonly ICartRepository _cartRepository;
    
    public CartService(ICartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    public void InitializeCart(string userId)
    {
        throw new NotImplementedException();
    }

    public Cart GetCartByUserId(string userId)
    {
        throw new NotImplementedException();
    }

    public void AddToCart(string userId, int productId, int quantity)
    {
        throw new NotImplementedException();
    }

    public void DeleteFromCart(string userId, int productId)
    {
        throw new NotImplementedException();
    }

    public void ClearCart(string cartId)
    {
        throw new NotImplementedException();
    }
}