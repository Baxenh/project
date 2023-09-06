using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
namespace Baitap2_Ls01_Quanly_hanghoa.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenderId { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int TolaPage { get; set; }
        public string Sumary { get; set; }

        // danh sách các cuons sách 
        // nhớ using system.Collection.Generic
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book(){
                    Id=1,
                    Title="Chí Phèo",
                    AuthorId=1,
                    GenderId=1,
                    Image="/Image/ao1.jpg",
                    Price=50000,
                    Sumary="",
                    TolaPage=250
                },
                new Book(){
                    Id=1,
                    Title="Chí Phèo",
                    AuthorId=2,
                    GenderId=2,
                    Image="/Image/ao1.jpg",
                    Price=50000,
                    Sumary="",
                    TolaPage=250
                },
                new Book(){
                    Id=1,
                    Title="Chí Phèo",
                    AuthorId=3,
                    GenderId=3,
                    Image="/Image/ao1.jpg",
                    Price=50000,
                    Sumary="",
                    TolaPage=250
                }       
            };
            return books;
        }
        // chi tiết cuốc sách theo id, nhớ using system.Linq
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        // Chi tiết cuốn sách theo id, nhớ using system.Linq
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text=" Nam Cao"},
            new SelectListItem{Value="2", Text=" Nam Cao"},
            new SelectListItem{Value="3", Text=" Nam Cao"},
            new SelectListItem{Value="4", Text=" Nam Cao"}
        };
        //selectListItem genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text=" Truyện tranh"},
            new SelectListItem{Value="2", Text=" Văn học đương đại"},
            new SelectListItem{Value="3", Text="Phật học phổ thông"},
            new SelectListItem{Value="4", Text=" truyện cười"}
        };
    }
}
