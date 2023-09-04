using Microsoft.AspNetCore.Mvc;

namespace Baitap_Lession02_QuanLy_hanghoa.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int YearRelease { get; set; }
        public double Price { get; set; }
    }
    
   
}
