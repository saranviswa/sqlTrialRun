using MFPE_ProductMicroservice.Models;
using ProductMicroservices.ProductDbContext;
using System.Collections.Generic;
using System.Linq;

namespace MFPE_ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _dbContext;

        public ProductRepository(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddProductRating(int Id, int rating)
        {
            Product P = new Product();
            P = _dbContext.Products.FirstOrDefault(x => x.Id == Id);

            P.Rating = rating;
            _dbContext.Products.Update(P);
            return _dbContext.SaveChanges();

        }

        public List<Product> GetAllProduct()
        {
            return _dbContext.Products.ToList();
        }

        public IEnumerable<Product> SearchProductByID(int Id)
        {
            return _dbContext.Products.Where(p => p.Id == Id);
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return _dbContext.Products.Where(p => p.Name.Contains(name));

        }
    }
}
