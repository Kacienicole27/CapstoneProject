using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace CapstoneProject.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Category>()
            //     .HasData(
            //     new Category { CategoryId = 1, CategoryName = "Art", Description = "Drawings and Paintings" },
            //     new Category { CategoryId = 2, CategoryName = "Design", Description = "Logos, Branding, and Advertisements" },
            //     new Category { CategoryId = 3, CategoryName = "Programs", Description = "Software and Websites" }
            //     );

            base.OnModelCreating(modelBuilder);
        }
    }
}
