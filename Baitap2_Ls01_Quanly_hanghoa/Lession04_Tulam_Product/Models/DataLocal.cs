namespace Lession04_Tulam_Product.Models
{
    public class DataLocal
    {
        // trả về có tên là products trong thu mục /View/Product
        List<Product> _products = new List<Product>()
        {
                new Product(){ Id = 1,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=1,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product(){ Id = 2,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=2,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product(){ Id = 3,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=3,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product(){ Id = 4,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=4,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product(){ Id = 5,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=5,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
        };

        public static List<Product> GetProducts()
        {
            return _products;
        }

        ///<summary>
        ///GetProducts: lấy danh sách dữ liệu
        /// </summary>
        /// <returns>List product</returns>
        /// 
        
        ///<summary>
        ///GetProductById: lấy sản phẩm theo Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>product</returns>
        /// 
        // public static Product? GetProductBYId(int id)
        // {
        ///     var product = _products.FirstOrDefault(x => x.Id == id);
        ///     return product;
        // }
    }
}
