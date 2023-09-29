using Microsoft.AspNetCore.Mvc;

namespace Lession07_NetCoreLab07.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
