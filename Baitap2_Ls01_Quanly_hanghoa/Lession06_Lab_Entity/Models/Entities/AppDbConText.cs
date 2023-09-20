using Microsoft.EntityFrameworkCore;

namespace Lession06_Lab_Entity.Models.Entities
{
    public class AppDbConText:DbContext
    {
        public AppDbConText(DbContextOptions<AppDbConText> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
