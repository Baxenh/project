using System.ComponentModel.DataAnnotations;

namespace Lession05_Tulam_Product_Category.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên"),
         Required(ErrorMessage ="Tên không được để trống"),
            MinLength(6,ErrorMessage ="Tên ít nhất phải 6 ký tự"),
            MaxLength(150, ErrorMessage = "Tên tối đa là 150 ký tự")            
            ]
        public string Name { get; set; }

        [Display(Name = "Giá cũ"),Required(ErrorMessage ="Giá phải nhỏ hơn 100000 ")]
        public double Price { get; set; }
        [Display(Name = "Giá mới"), Required(ErrorMessage = "Giá không được âm và phải nhỏ hơn giá chuẩn 10%")]
        public double SalePrice { get; set; }


        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }


        [Display(Name = "Ảnh đại diện")]
        public string Images { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Mã Danh mục")]
        public int CategoryId { get; set; }
        [Display(Name = "Mô tả")]        
         [StringLength(150, ErrorMessage = "Mô tả không quá 1500 ký tự")]
        public string Description { get; set; }
    }
}
