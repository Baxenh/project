using Baitap_Lession02_QuanLy_hanghoa.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Baitap_Lession02_QuanLy_hanghoa.Controllers
{
    [Route("Danh-sach")]
    public class ProductController : Controller

    {
        [Route("")]
        //actions mặc định khi controler được tạo ra
       
        public IActionResult Index()
        {
            // trả về view có tên trùng tên actios trong thư mục /view/product
            ViewData["mesageVD"] = "Dữ iệu lưu trong ViewData";
            ViewBag.messageVB = "Dữ liệu lưu trong ViewBag";
            TempData["mesageTD"] = "Dữ liệu lưu trong TempData";
            return View();

        }

        [Route("get-product")]
        public IActionResult GetProduct()
        {
            Product p = new Product()
            {
                ProductId = 1,
                ProductName = "Trek 820- 2016",
                YearRelease = 2016,
                Price = 379.99
            };
            ViewBag.product = p;
            ViewData["productVD"] = p;
            return View();

        }

        [Route("list-product")]
        //định nghĩa actions mới
        public IActionResult ListProduct(int? id)
        {
            //trả về có tên là products trong thư mục/Views/Product
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductId = 1,ProductName="Trek 820 - 2016", YearRelease=2016, Price=379.99},
                new Product(){ ProductId = 2,ProductName="Ritchay Timberwolf Frameset - 2016", YearRelease=2016, Price=749.99},
                new Product(){ ProductId = 3,ProductName="Surly Wednesday Frameset - 2016", YearRelease=2016, Price=999.99},
                new Product(){ ProductId = 4,ProductName="Trek Fuel EX 8 29 - 2016", YearRelease=2016, Price=2899.99},
                new Product(){ ProductId = 5,ProductName="Heller Shagamaw Frame - 2016", YearRelease=2016, Price=1320.99},
                new Product(){ ProductId = 6,ProductName="Surly Ice Cream Truck Frameset - 2016", YearRelease=2016, Price=469.99},
                new Product(){ ProductId = 7,ProductName="Trek Slash 8 27.5 - 2016", YearRelease=2016, Price=3999.99},
                new Product(){ ProductId = 8,ProductName="Trek Remedy 29 Carbon Frameset - 2016", YearRelease=2016, Price=1799.99},
                new Product(){ ProductId = 9,ProductName="Trek Conduit+ - 2016", YearRelease=2016, Price=2999.99},
                new Product(){ ProductId = 10,ProductName="Surly Straggler - 2016", YearRelease=2016, Price=1549.0},
                new Product(){ ProductId = 11,ProductName="Surly Straggler 650b - 2016", YearRelease=2016, Price=1680.99},
                new Product(){ ProductId = 12,ProductName= "Electra Townie Original 21D - 2016", YearRelease = 2016, Price = 549.99},
                new Product(){ ProductId = 13,ProductName= "Electra Cruiser 1 (24-Inch) - 2016", YearRelease = 2016, Price = 269.99},
                new Product(){ ProductId = 14,ProductName= "Electra Girl's Hawaii 1 (16-inch) - 2015/2016", YearRelease = 2016, Price = 269.99},
            };
            if (id != null)
            {
                products = products.Where(x => x.ProductId == id).ToList();
            }
            ViewBag.products = products;
            return View();
        }
        [Route("get-list-product")]        
        
        public IActionResult GetListProduct(int? Id)
        {
            List<Product> products=new List<Product>()
            {
                new Product(){ ProductId = 1,ProductName="Trek 820 - 2016", YearRelease=2016, Price=379.99},
                new Product(){ ProductId = 2,ProductName="Ritchay Timberwolf Frameset - 2016", YearRelease=2016, Price=749.99},
                new Product(){ ProductId = 3,ProductName="Surly Wednesday Frameset - 2016", YearRelease=2016, Price=999.99},
                new Product(){ ProductId = 4,ProductName="Trek Fuel EX 8 29 - 2016", YearRelease=2016, Price=2899.99},
                new Product(){ ProductId = 5,ProductName="Heller Shagamaw Frame - 2016", YearRelease=2016, Price=1320.99},
                new Product(){ ProductId = 6,ProductName="Surly Ice Cream Truck Frameset - 2016", YearRelease=2016, Price=469.99},
                new Product(){ ProductId = 7,ProductName="Trek Slash 8 27.5 - 2016", YearRelease=2016, Price=3999.99},
                new Product(){ ProductId = 8,ProductName="Trek Remedy 29 Carbon Frameset - 2016", YearRelease=2016, Price=1799.99},
                new Product(){ ProductId = 9,ProductName="Trek Conduit+ - 2016", YearRelease=2016, Price=2999.99},
                new Product(){ ProductId = 10,ProductName="Surly Straggler - 2016", YearRelease=2016, Price=1549.0},
                new Product(){ ProductId = 11,ProductName="Surly Straggler 650b - 2016", YearRelease=2016, Price=1680.99},
                new Product(){ ProductId = 12,ProductName= "Electra Townie Original 21D - 2016", YearRelease = 2016, Price = 549.99},
                new Product(){ ProductId = 13,ProductName= "Electra Cruiser 1 (24-Inch) - 2016", YearRelease = 2016, Price = 269.99},
                new Product(){ ProductId = 14,ProductName= "Electra Girl's Hawaii 1 (16-inch) - 2015/2016", YearRelease = 2016, Price = 269.99},
            };
            if(Id!=null)
            {
                products = products.Where(x => x.ProductId == Id).ToList();
            }    
            return Json(products);
        }
    }
}
