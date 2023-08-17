namespace Entities.Entities;

public class CartItem : BaseEntity
{
    public Product Product { get; set; }
    public int ProductId { get; set; }

    public Cart Cart { get; set; }
    public int CartId { get; set; }

    public int Quantity { get; set; }
}