using System.ComponentModel.DataAnnotations;

namespace MFPE_ProductMicroservice.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image_Name { get; set; }
        public int Rating { get; set; }
    }
}
