using ProductSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductSolution.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }

        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title="Power of Now", Author = "John Smith", Description = "Blah blah blah", ISBN = "924921949214", ListPrice = 20, Price = 30, Price100 = 20, Price50 = 25 },
                new Product { Id = 2, Title="Life3.0", Author = "Susan Joan", Description = "Blah blah blah", ISBN = "924923449214", ListPrice = 50, Price = 50, Price100 = 30, Price50 = 35 },
                new Product { Id = 3, Title="Diet Book", Author = "John Smith", Description = "Blah blah blah", ISBN = "924921949214", ListPrice = 20, Price = 20, Price100 = 15, Price50 = 20 }

                );
        }
    }
}
