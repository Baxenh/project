using Lession07Lab07_BTTL_Bai2_NetCore_MVC_Product.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Lession07Lab07_BTTL_Bai2_NetCore_MVC_Product.Models.BusinessModels
{
    public class ProductManagementContext:DbContext
    {
        public ProductManagementContext(DbContextOptions<ProductManagementContext>options) : base(options)
        {

        }
            
        //Khai báo các thuộc tính
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Banner> Banners { get; set; }


    }
}
