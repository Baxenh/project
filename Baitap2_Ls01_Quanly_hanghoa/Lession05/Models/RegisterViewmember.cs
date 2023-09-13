using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Lession05.Models
{
    public class RegisterViewmember
    {
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Tên đăng nhập không được để trống")]
        [StringLength(20,MinimumLength=3,ErrorMessage ="Độ dài từ 3-20 ký tự")]
        public string UserName { get; set; }
        [Display(Name = "Họ và tên đăng nhập")]
        [Required(ErrorMessage = "Họ Tên không được để trống")]
        public string FullName { get; set; }
        public string Password { get; set; }
        [Display(Name = "Email đăng nhập")]
        [RegularExpression(@"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email không được định dạng")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
    }
}
