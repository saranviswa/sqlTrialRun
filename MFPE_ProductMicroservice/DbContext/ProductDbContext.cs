using MFPE_ProductMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductMicroservices.ProductDbContext
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product() { Id = 1, Price = 15000, Name = "Mobile phone", Description = "This is a brand new mobile phone", Image_Name = "MobilePhone.jpg", Rating = 2 },
                    new Product() { Id = 2, Price = 2000, Name = "Pendrive", Description = "This is a brand new Pendrive", Image_Name = "PenDrive.jpg", Rating = 3 },
                    new Product() { Id = 3, Price = 2000, Name = "HeadPhones", Description = "This is a brand new HeadPhone", Image_Name = "Headphone.jpg", Rating = 4 },
                    new Product() { Id = 4, Price = 35000, Name = "Laptop", Description = "This is a brand new Laptop", Image_Name = "Laptop.jpg", Rating = 3 }



                );
        }



    }
}
