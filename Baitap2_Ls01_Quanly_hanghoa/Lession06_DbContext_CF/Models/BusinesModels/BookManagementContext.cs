using Lession06_DbContext_CF.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Lession06_DbContext_CF.Models.BusinesModels
{
    public class BookManagementContext:DbContext
    {
        public BookManagementContext(DbContextOptions<BookManagementContext> options) : base(options)
        { 
        
        }
        //khai báo các thuộc tính biểu diễn tập thực thể
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<Publisher> publishers { get; set; }

    }
}
