using Microsoft.AspNetCore.Mvc;
using Baitap2_Ls01_Quanly_hanghoa.Models;

namespace Baitap2_Ls01_Quanly_hanghoa.ViewComponents
{
    public class BookViewComponent:ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}
