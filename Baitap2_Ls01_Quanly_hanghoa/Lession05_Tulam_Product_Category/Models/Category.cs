using System.ComponentModel.DataAnnotations;

namespace Lession05_Tulam_Product_Category.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Tên Danh mục sản phẩm")]
        [Required(ErrorMessage ="Tên danh mục không dduwwojc để trống")]
        [StringLength(20, ErrorMessage ="Tên danh mục tối đa 20 ký tự")]
        public string Name { get; set; }
    }
}
