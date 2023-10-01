using Microsoft.AspNetCore.Mvc;

namespace Lesson08_Lab08_Demo_Product.Areas.Admins.Controllers
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
