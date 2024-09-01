using Microsoft.EntityFrameworkCore;
using ProductOrderManagement.Domain.Entities;

namespace ProductOrderManagement.Infrastructure
{
    public class ProductOrderManagementDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        public ProductOrderManagementDbContext(DbContextOptions<ProductOrderManagementDbContext> options): base(options)
        {
            
        }
    }
}
