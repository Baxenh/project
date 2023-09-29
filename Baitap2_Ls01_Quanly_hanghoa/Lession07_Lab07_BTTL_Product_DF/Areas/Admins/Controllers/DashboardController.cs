using Microsoft.AspNetCore.Mvc;

namespace Lession07_Lab07_BTTL_Product_DF.Areas.Admins.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
