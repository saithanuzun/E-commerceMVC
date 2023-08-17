using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class ShopContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string connection = "";

        optionsBuilder.UseNpgsql(connection);
    }
    public DbSet<Product> Products{ get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Order> Orders { get; set; }
}