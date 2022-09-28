using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderFoodItem>()
                .HasKey(cs => new { cs.OrderId, cs.FoodItemId });
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<OrderFoodItem> OrderFoodItems { get; set; }

    }
}