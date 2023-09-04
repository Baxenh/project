using Microsoft.AspNetCore.Mvc;

namespace Baitap_Lession02_QuanLy_hanghoa.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
       public double Price { get; set; }
        public double SalePrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public int Status{ get; set; }
        public DateTime CreateAt { get; set; }
    }
    
   
}
