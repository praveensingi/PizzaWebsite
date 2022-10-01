using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models;
using System;

namespace Restaurante.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Restaurante.Models.Customer> Customer { get; set; }
        public DbSet<Restaurante.Models.FoodItem> FoodItem { get; set; }
        public DbSet<Restaurante.Models.OrderFoodItem> OrderFoodItem { get; set; }
        public DbSet<Restaurante.Models.Order> Order { get; set; }
        public DbSet<Restaurante.Models.Staff> Staff { get; set; }
    }
}