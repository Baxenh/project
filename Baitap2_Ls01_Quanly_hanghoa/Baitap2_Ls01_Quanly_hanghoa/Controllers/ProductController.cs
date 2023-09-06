using Baitap2_Ls01_Quanly_hanghoa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Baitap2_Ls01_Quanly_hanghoa.Controllers
{
    public class ProductController : Controller
    {
        private List<Category> lsCategory = new List<Category>()
            {
                 new Category(){Id=1,Name="Quần áo" },
                 new Category(){Id=2,Name="Túi xách"},
                 new Category(){Id=3,Name="Đồng hồ"},
                 new Category(){Id=4,Name="Tivi"},
                 new Category(){Id=5,Name="Quạt điện"},
                 new Category(){Id=6,Name="Lò sưởi"},
                 new Category(){Id=7,Name="Máy bơm"}
            };
        
      
        private List<Product> lsProducts = new List<Product>()
        {
                new Product()
                {
                   Id=1, 
                   Name="Bộ đồ cho trẻ em nam",  
                  Image= "/Image/ao1.jpg",
                  Price=25000, SalePrice=20000,
                  CategoryId=1,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,08,25)
                 },
                 new Product()
                 {
                     Id = 2,
                    Name="Bộ đồ cho trẻ em nam",
                 Image= "/Image/ao6.jpg",
                  Price=25000,SalePrice=20000,
                  CategoryId=2,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,06,07)
                 },
                  new Product()
                 {
                     Id = 3,
                     Name="Bộ đồ cho trẻ em nữ",
                  Image= "/Image/ao3.jpg",
                  Price=35000, SalePrice=20000,
                  CategoryId=3,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,02,07)
                  },
                    new Product()
                 {
                     Id = 4,
                    Name="Bộ đồ Váy cho trẻ em nữ",
                  Image= "/Image/ao4.jpg",
                  Price=35000, SalePrice=20000,
                  CategoryId=4,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,08,07)
                 }
                   ,
                    new Product()
                 {
                    Id = 5,
                    Name="Túi xách cho nữ",
                 Image= "/Image/tui3.jpg",
                  Price=25000,  SalePrice=20000,
                  CategoryId=5,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,02,07)
                 }
                   ,
                    new Product()
                 {
                     Id = 6,
                     Name="Túi xách cho trẻ em",
                 Image= "/Image/tui1.jpg",
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=6,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,07,07)
                 }
                    ,
                    new Product()
                 {
                     Id = 7,
                     Name="Túi xách cho  giới trẻ",
                 Image= "/Image/tui2.jpg",
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=7,
                   Description="My name is Small",
                   Status=true,
                   CreateAt= new DateTime(2023,05,07)
                 }
                    ,
                    new Product()
                 {
                     Id = 8,
                     Name="Đồ cho trẻ em",
                 Image= "/Image/ao5.jpg",
                  Price=25000,
                  SalePrice=20000,
                  CategoryId=8,
                   Description="My name is Small",
                   Status=false,
                   CreateAt= new DateTime(2023,06,07)
                 }
        };

       

           private Product details = new Product()
            {                  
                   Id=1,
                  Name="Bộ đồ chơi cho trẻ em nam",
                  Image= "/Image/ao6.jpg",
                  Price=25000, SalePrice=20000,
                  CategoryId=1,
                   Description= "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Molestias, quasi. Itaque doloribus aspernatur error numquam voluptas quia, impedit quos commodi, rem minus quidem, cumque quasi natus dolorem ducimus ut architecto?",
                   Status=true,
                   CreateAt= new DateTime(2023,08,07)
            };

         
        public IActionResult Index(int? id)
        {
            ViewBag.Products = lsProducts;
            if (id != null)
            {
                lsProducts = lsProducts.Where(x => x.CategoryId == id.Value).ToList();
            }
            ViewBag.Categories = lsCategory;
            ViewBag.Details = details;
            return View();
        }
    }
}

