using Baitap_Lession02_QuanLy_hanghoa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Baitap2_Ls01_Quanly_hanghoa.Controllers
{
    public class ProductController : Controller
    {
        [Route("Danh-sach-san-pham")]
        public IActionResult Index(int? id)
        {          
            List<Product> products = new List<Product>()
            {
                     new Product()
                {
                   Id=1, 
                   Name="Bộ đồ cho trẻ em nam",  
                  Avatar= Url.Content("~/Avatar/ao1.jpg"),
                  Price=25000, SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,08,25)
                     },
                 new Product()
                 {
                     Id = 2,
                    Name="Bộ đồ cho trẻ em nam",
                 Avatar= Url.Content("~/Avatar/ao6.jpg"),
                  Price=25000,SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,06,07)
                 },
                  new Product()
                 {
                     Id = 3,
                     Name="Bộ đồ cho trẻ em nữ",
                  Avatar= Url.Content("~/Avatar/ao3.jpg"),
                  Price=35000, SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,02,07)
                  },
                    new Product()
                 {
                     Id = 4,
                    Name="Bộ đồ Váy cho trẻ em nữ",
                  Avatar= Url.Content("~/Avatar/ao4.jpg"),
                  Price=35000, SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=0,
                   CreateAt= new DateTime(2023,08,07)
                 }
                   ,
                    new Product()
                 {
                    Id = 5,
                    Name="Túi xách cho nữ",
                 Avatar= Url.Content("~/Avatar/tui3.jpg"),
                  Price=25000,  SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,02,07)
                 }
            ,
                    new Product()
                 {
                     Id = 6,
                     Name="Túi xách cho trẻ em",
                 Avatar= Url.Content("~/Avatar/tui1.jpg"),
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=0,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,07,07)
                 }
                    ,
                    new Product()
                 {
                     Id = 7,
                     Name="Túi xách cho  giới trẻ",
                 Avatar= Url.Content("~/Avatar/tui2.jpg"),
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,05,07)
                 }
                    ,
                    new Product()
                 {
                     Id = 8,
                     Name="Đồ cho trẻ em",
                 Avatar= Url.Content("~/Avatar/ao5.jpg"),
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=0,
                   Description="My name is Small",
                   Status=1,
                   CreateAt= new DateTime(2023,06,07)
                 }

            };
            if (id != null)
            {
                products = products.Where(x => x.Id == id).ToList();
            }
            ViewBag.Products = products;
            return View();
        }
        [Route("Chi-tiết-san-pham", Name = "Detail")]
        public IActionResult Detail()
        {

            Product details = new Product()
            {                   
               
                   Id=1,
                   Name="Bộ đồ chơi cho trẻ em nam",
                  Avatar= Url.Content("~/Avatar/ao6.jpg"),
                  Price=25000, SalePrice=20000,
                  CategoryId=1,
                   Description= "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Molestias, quasi. Itaque doloribus aspernatur error numquam voluptas quia, impedit quos commodi, rem minus quidem, cumque quasi natus dolorem ducimus ut architecto?",
                   Status=1,
                   CreateAt= new DateTime(2023,08,07)
                 };
            //gửi đối tượng account qua view
            ViewBag.Details = details;
            return View();
         }

        [Route("Danh-muc-san-pham", Name = "Category")]
        public IActionResult Category()
        {
            List<Category> categories = new List<Category>()
            {
                     new Category()
                {
                   CategoryId=1,
                   CategoryName="Quần áo"
                 },
                         new Category()
                {
                   CategoryId=2,
                   CategoryName="Túi xách"
                 },
                             new Category()
                {
                   CategoryId=3,
                   CategoryName="Đồng hồ"
                 },
                                 new Category()
                {
                 CategoryId=4,
                   CategoryName="Tivi"
                 },
                                 
                                 new Category()
                {
                 CategoryId=4,
                   CategoryName="Quạt điện"
                 },
                                 
                                 new Category()
                {
                 CategoryId=4,
                   CategoryName="Lò sưởi"
                 },
                                 
                                 new Category()
                {
                 CategoryId=4,
                   CategoryName="Máy bơm"
                 }
            };
            ViewBag.Categories = categories;
            return View();
        }
    }
}

