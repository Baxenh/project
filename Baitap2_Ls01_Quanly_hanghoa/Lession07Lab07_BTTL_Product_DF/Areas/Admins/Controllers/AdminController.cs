using Microsoft.AspNetCore.Mvc;

namespace Lession07Lab07_BTTL_Product_DF.Areas.Admins.Controllers
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
