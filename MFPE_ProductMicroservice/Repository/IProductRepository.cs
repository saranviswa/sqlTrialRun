using MFPE_ProductMicroservice.Models;
using System.Collections.Generic;

namespace MFPE_ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetAllProduct();
        public IEnumerable<Product> SearchProductByID(int Id);
        public IEnumerable<Product> SearchProductByName(string name);

        public int AddProductRating(int Id, int rating);
    }
}
