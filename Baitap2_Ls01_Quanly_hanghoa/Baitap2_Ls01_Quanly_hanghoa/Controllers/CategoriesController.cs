using Baitap_Lession02_QuanLy_hanghoa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baitap2_Ls01_Quanly_hanghoa.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Categories(int? id) 
        { 
            List<Categories> categoriess = new List<Categories>()
            {
                     new Categories()
                {
                   CategoryId=1,
                   CategoryName="Quần áo"
                 },
                     new Categories()
                {
                   CategoryId=2,
                   CategoryName="Túi xách"
                 },
                      new Categories()
                {
                   CategoryId=3,
                   CategoryName="Đồng hồ"
                 },
                      new Categories()
                {
                 CategoryId=4,
                   CategoryName="Tivi"
                 },

                       new Categories()
                {
                 CategoryId=4,
                   CategoryName="Quạt điện"
                 },

                                 new Categories()
                {
                 CategoryId=4,
                   CategoryName="Lò sưởi"
                 },

                                 new Categories()
                {
                 CategoryId=4,
                   CategoryName="Máy bơm"
                 }
          };
            if(id!= null)
            {
                categoriess = categoriess.Where(x=>x.CategoryId==id).ToList();
            }
                ViewBag.Categoriess = categoriess;
                return View();            
        }

        public IActionResult DetailCate() 
        {
            Categories cate = new Categories()
             {
                 CategoryId = 1,
                 CategoryName = "Quần áo"
             };
            ViewBag.Categories = cate;
            return View();
        }
        public IActionResult Product(int? id)
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
       
        public IActionResult DetailPro()
        {

            Product detailPro = new Product()
            {

                Id = 1,
                Name = "Bộ đồ chơi cho trẻ em nam",
                Avatar = Url.Content("~/Avatar/ao6.jpg"),
                Price = 25000,
                SalePrice = 20000,
                CategoryId = 1,
                Description = "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Molestias, quasi. Itaque doloribus aspernatur error numquam voluptas quia, impedit quos commodi, rem minus quidem, cumque quasi natus dolorem ducimus ut architecto?",
                Status = 1,
                CreateAt = new DateTime(2023, 08, 07)
            };
            //gửi đối tượng account qua view
            ViewBag.DetailPro = detailPro;
            return View();
        }

    }
}
