using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lession05_App_Account.Models
{
    public class Account
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên"),
          Required(ErrorMessage = "Họ không để trống"),
           MinLength(6, ErrorMessage = "Họ tên ít phải 16 ký tự"),
           MaxLength(20, ErrorMessage = "Họ tên tối đa là 20 ký tự")]
        public string FullName { get; set; }


        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }




        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action:"VerifyPhone",controller:"Acccount")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không được định dạng")]
         public string Phone { get; set; }




        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }




        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


       
        [Display(Name = "Giới tính")]
        public byte Gender { get; set; }

        [Display(Name = "Link facebook cá nhân")]
        [Required(ErrorMessage = "Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm  https://www.facebook.com/acommitment.make/")]
        public string Facebook{ get; set; }

    }
}
