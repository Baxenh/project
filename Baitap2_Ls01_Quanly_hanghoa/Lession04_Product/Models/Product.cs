using System.ComponentModel.DataAnnotations;

namespace Lession04_Product.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Họ và tên")]
        public string Name { get; set; }
        [Display(Name = "Giá cũ")]
        public double Price { get; set; }
        [Display(Name = "Giá mới")]
        public double SalePrice { get; set; }
        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Images { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }

    }
}
