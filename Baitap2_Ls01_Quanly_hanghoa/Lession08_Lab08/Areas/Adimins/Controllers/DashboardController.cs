using Microsoft.AspNetCore.Mvc;

namespace Lession08_Lab08.Areas.Adimins.Controllers
{
    [Area("Admins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
