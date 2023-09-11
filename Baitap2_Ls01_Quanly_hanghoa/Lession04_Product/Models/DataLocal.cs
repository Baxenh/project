namespace Lession04_Product.Models
{
    public class DataLocal
    {
        public static List<Product> _products = new List<Product>()
        {
         new Product() { Id = 1,
             Name = "Xenh",
             Price = 379.99,
             SalePrice = 399.00,
             Status = true,
             Images ="Images/bag2.jpg",
             CreateDate = Convert.ToDateTime("1985, 12, 07"),
             CategoryId = 1,
             Description = "Devmaster"},
         new Product() { Id = 2,
             Name = "Xenh",
             Price = 379.99,
             SalePrice = 399.00,
             Status = false,
             Images = "Images/bag3.jpg",
             CreateDate = Convert.ToDateTime("1985, 12, 07"),
             CategoryId = 2,
             Description = "Devmaster"},
         new Product() { Id = 3,
             Name = "Xenh",
             Price = 379.99,
             SalePrice = 399.00,
             Status = true,
             Images = "Images/bag4.jpg",
             CreateDate = Convert.ToDateTime("1985, 12, 07"),
             CategoryId = 3,
             Description = "Devmaster"},
         new Product() { Id = 4,
             Name = "Xenh",
             Price = 379.99,
             SalePrice = 399.00,
             Status = true,
             Images = "Images/bag5.jpg",
             CreateDate = Convert.ToDateTime("1985, 12, 07"),
             CategoryId = 4,
             Description = "Devmaster"},
            };
        public static List<Product> GetProducts()
        {
            return _products;
        }
        public static Product? GetProductById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return product;
        }



    }
}
