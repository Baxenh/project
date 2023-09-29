using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lession07Lab07_BTTL_Bai2_NetCore_MVC_Product.Models.DataModels
{
    [Table("Products")]
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        [StringLength(10)]
        public int Id { get; set; }


        [DisplayName("Tên sản phẩm")]
        [StringLength(100)]
        public string Name { get; set; }
        [DisplayName("Giá cũ")]      
        public float Price { get; set; }

        [DisplayName("Giá mới")]
        public float SalePrice { get; set; }

        [DisplayName("Trạng thái")]
        public bool Status { get; set; }


        [DisplayName("Ngày tạo")]
        public DateTime CreateDate { get; set; }


        [DisplayName("Ảnh đại diện")]
        public string Image { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }
        /// <summary>
        /// tạo quab hệ giữa các thực thể
        /// </summary>
        public Category Category { get; set; }
        public Blog Blog { get; set; }
        public Banner Banner { get; set; }

        
    }
}
