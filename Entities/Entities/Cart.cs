namespace Entities.Entities;

public class Cart : BaseEntity
{
    public string UserId { get; set; }

    public List<CartItem> CartItems { get; set; }
}