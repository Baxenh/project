using Baitap_Lession02_QuanLy_hanghoa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baitap_Lession02_QuanLy_hanghoa.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>()
            {
                     new Account()
                {
                   Id=1, Name="Xenh",
                   Email="xenhit2019@gmail.com",
                   Phone="0346697228",
                   Address="Long Bien- Ha Noi",
                   Avatar= Url.Content("~/Avatar/bag2.jpg"),
                   Gender=1,
                   Bio="My name is Small",
                   Birthday = new DateTime(1985,12,07)
                },
                 new Account()
                 {
                     Id = 2,
                     Name = "Xenh",
                     Email = "xenhit2019@gmail.com",
                     Phone = "0346697228",
                     Address = "Long Bien- Ha Noi",
                     Avatar = Url.Content("~/Avatar/bag2.jpg"),
                     Gender = 1,
                     Bio = "My name is Small",
                     Birthday = new DateTime(1985, 12, 07)
                 },
                  new Account()
                 {
                     Id = 3,
                     Name = "Xenh",
                     Email = "xenhit2019@gmail.com",
                     Phone = "0346697228",
                     Address = "Long Bien- Ha Noi",
                     Avatar = Url.Content("~/Avatar/bag2.jpg"),
                     Gender = 1,
                     Bio = "My name is Small",
                     Birthday = new DateTime(1985, 12, 07)
                 },
                    new Account()
                 {
                     Id = 4,
                     Name = "Xenh",
                     Email = "xenhit2019@gmail.com",
                     Phone = "0346697228",
                     Address = "Long Bien- Ha Noi",
                     Avatar = Url.Content("~/Avatar/bag2.jpg"),
                     Gender = 1,
                     Bio = "My name is Small",
                     Birthday = new DateTime(1985, 12, 07)
                 }
                    ,
                    new Account()
                 {
                     Id = 4,
                     Name = "Xenh",
                     Email = "xenhit2019@gmail.com",
                     Phone = "0346697228",
                     Address = "Long Bien- Ha Noi",
                     Avatar = Url.Content("~/Avatar/bag2.jpg"),
                     Gender = 1,
                     Bio = "My name is Small",
                     Birthday = new DateTime(1985, 12, 07)
                 }

                    ,
                    new Account()
                 {
                     Id = 4,
                     Name = "Xenh",
                     Email = "xenhit2019@gmail.com",
                     Phone = "0346697228",
                     Address = "Long Bien- Ha Noi",
                     Avatar = Url.Content("~/Avatar/bag2.jpg"),
                     Gender = 1,
                     Bio = "My name is Small",
                     Birthday = new DateTime(1985, 12, 07)
                 }

            };

            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name ="Profile")]
        public IActionResult Profile()
        {
            Account account = new Account()
            {
                Id = 3,
                Name = "Xenh",
                Email = "xenhit2019@gmail.com",
                Phone = "0346697228",
                Address = "Long Bien- Ha Noi",
                Avatar = Url.Content("~/Avatar/bag2.jpg"),
                Gender = 1,
                Bio = "My name is Small",
                Birthday = new DateTime(1985, 12, 07)
            };
            //Gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }        
    }
}
