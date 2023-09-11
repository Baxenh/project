using System.ComponentModel.DataAnnotations;

namespace Lession04_Product.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name="Tên Danh mục sản phẩm")]
        public string Name { get; set; }
    }
}
