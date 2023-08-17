using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class ShopContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string connection = "USER ID=postgres ; Password=password123;Server=localhost;Port=5432;Database=shop ;Integrated Security=true;Pooling=true";

        optionsBuilder.UseNpgsql(connection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>()
            .HasKey(c => new { c.CategoryId, c.ProductId });
    }
    public DbSet<Product> Products{ get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart?> Carts { get; set; }
    public DbSet<Order> Orders { get; set; }
}