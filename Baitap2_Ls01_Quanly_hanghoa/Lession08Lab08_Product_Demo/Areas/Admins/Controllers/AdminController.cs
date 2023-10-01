using Microsoft.AspNetCore.Mvc;

namespace Lession08Lab08_Product_Demo.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
