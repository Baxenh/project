using Lession04.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace Lession04.Controllers
{
    public class MembersController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
