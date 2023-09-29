using Microsoft.AspNetCore.Mvc;

namespace Lession07Lab07_BTTL_Product.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
