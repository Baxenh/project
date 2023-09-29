using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Lession07Lab07_BTTL_Bai2_NetCore_MVC_Product.Models.DataModels
{
    [Table("Banner")]
    public class Banner
    {
        [DisplayName("Mã Danh mục")]
        [StringLength(10)]
        public int Id { get; set; }


        [DisplayName("Tên Danh mục")]
        [StringLength(200)]
        public string Name { get; set; }


        [DisplayName("Trạng thái")]
        public bool Status { get; set; }


        [DisplayName("Ưu tiên")]
        public int Prioty { get; set; }


        [DisplayName("Ảnh đại diện")]
        public string Image { get; set; }


        [DisplayName("Mô tả")]
        [StringLength(500)]
        public string Descripton { get; set; }

        // thuộc tính quan hệ
        public ICollection<Product> Product { get; set; }
    }
}
