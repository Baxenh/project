using System.ComponentModel.DataAnnotations;
namespace Lession04_Tulam_Product.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public bool Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
    
}
