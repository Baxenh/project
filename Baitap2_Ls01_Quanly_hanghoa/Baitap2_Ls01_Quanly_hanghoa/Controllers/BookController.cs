using Baitap2_Ls01_Quanly_hanghoa.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baitap2_Ls01_Quanly_hanghoa.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            //Danh sách genres convert SelectListItem để hiển thị trên combox
            ViewBag.authors = book.Authors;//turuyen dl SelectListItem qua view
            ViewBag.genres = book.Genres; //turuyen dl SelectListItem qua view
            var books = book.GetBookList();
            return View(books);// truyen  du lieu duoi dang tham so
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;//turuyen dl SelectListItem qua view
            ViewBag.genres = book.Genres; //turuyen dl SelectListItem qua view
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Authors;//turuyen dl SelectListItem qua view
            ViewBag.genres = book.Genres; //turuyen dl SelectListItem qua view
            Book model = book.GetBookById(id);
            return View(model);
        }
        public IActionResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }

    }
}
