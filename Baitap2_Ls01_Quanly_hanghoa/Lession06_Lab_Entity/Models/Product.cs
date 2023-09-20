using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lession06_Lab_Entity.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150, ErrorMessage = "Tên sản phẩm giới hạn 150 ký tự")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được trống")]
        public double Price { get; set; }
        [Display(Name = "Giá sản phẩm không được trống"), Required(ErrorMessage = "Giá không được âm và phải nhỏ hơn giá chuẩn 10%")]
        public double SalePrice { get; set; }


        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }


        [Column(TypeName = "varchar(150)")]
        public string Image { get; set; }


        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm không được để trống")]
        public int CategoryId { get; set; }
        [Display(Name = "Mô tả")]
        [StringLength(100, ErrorMessage = "Mô tả không quá 1000 ký tự")]
        [Column(TypeName = "ntext")]

        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
