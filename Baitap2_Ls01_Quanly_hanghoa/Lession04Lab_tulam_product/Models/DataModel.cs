
namespace Lession04Lab_tulam_product.Models
{
    public class DataModel

    {
       public static List<Products> _products = new List<Products>()
        {
                new Products() { Id = 1,Name = "Xenh", Price = 379.99,SalePrice = 357.00,Status = true,CreateDate = new DateTime(2023, 08, 25),Image = "Images/avatar/ao1.jpg",CategoryId = 1,Description = "orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Products() { Id = 2,Name = "Xenh", Price = 379.99,SalePrice = 357.00,Status = true,CreateDate = new DateTime(2023, 08, 25),Image = "Images/avatar/ao1.jpg",CategoryId = 2,Description = "orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Products() { Id = 3,Name = "Xenh", Price = 379.99,SalePrice = 357.00,Status = true,CreateDate = new DateTime(2023, 08, 25),Image = "Images/avatar/ao1.jpg",CategoryId = 3,Description = "orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Products() { Id = 4,Name = "Xenh", Price = 379.99,SalePrice = 357.00,Status = true,CreateDate = new DateTime(2023, 08, 25),Image = "Images/avatar/ao1.jpg",CategoryId = 4,Description = "orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Products() { Id = 5,Name = "Xenh", Price = 379.99,SalePrice = 357.00,Status = true,CreateDate = new DateTime(2023, 08, 25),Image = "Images/avatar/ao1.jpg",CategoryId = 5,Description = "orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
        };
        ///<sumary>
        ///GetProducts: Lấy danh sách dữ liệu
        ///</sumary>
        ///<returns></returns>
        public static List<Products> GetProducts()
        {
            return _products;
        }

        ///
        ///<sumary>
        ///GetProducts: Lấy đối tượng People theo Id
        ///</sumary>
        ///<param name="ID"></param>
        ///<returns>products</returns>
        public static Products?  GetProductById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return product;
        }


      

    }
}
