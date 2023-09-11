using static System.Net.Mime.MediaTypeNames;

namespace Lession04_Lab_Tulam.Models
{
    public class DataLocal
    {

        //trả về có tên là products trong thư mục/Views/Product
        List<Product1> _products = new List<Product1>()
            {
                new Product1(){ Id = 1,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=1,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product1(){ Id = 2,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=2,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product1(){ Id = 3,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=3,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product1(){ Id = 4,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=4,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
                new Product1(){ Id = 5,Name="Xenh", Price=379.99,SalePrice=357.00,Status=true,CreateDate= new DateTime(2023,08,25),Image= "Images/avatar/ao1.jpg",CategoryId=5,Description="orem Ipsum chỉ đơn giản là một đoạn văn bản giả, được dùng vào việc trình bày và dàn trang phục vụ cho in ấn. Lorem Ipsum đã được sử dụng như một văn bản chuẩn cho ngành công nghiệp in ấn từ những năm 1500, khi một họa sĩ vô danh ghép nhiều đoạn văn bản với nhau để tạo thành một bản mẫu văn bản. Đoạn văn bản này không những đã tồn tại năm thế kỉ, mà khi được áp dụng vào tin học văn phòng, nội dung của nó vẫn không hề bị thay đổi."},
            };
        ///<sumary>
        ///GetProducts: Lấy danh sách dữ liệu
        ///</sumary>
        ///<returns></returns>

        
        public static List<Product1> GetProducts()
        {
            return _products;
        }
        ///<sumary>
        ///GetProducts: Lấy đối tượng People theo Id
        ///</sumary>
        ///<param name="ID"></param>
        ///<returns>Product</returns>
        public static Product1? GetPeopleById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return product;
        }


        List<Category> _categories = new List<Category>()
        {
            new Category(){ Id = 1,Name="Quần Ao"},
            new Category(){ Id = 2,Name="Laptop"},
            new Category(){ Id = 3,Name="Linh kiện"},
            new Category(){ Id = 4,Name="Loa đài"},
            new Category(){ Id = 5,Name="Máy Bơm"},
        };
        ///<sumary>
        ///GetProduct: Lấy danh sách dữ liệu
        ///</sumary>
        ///<returns></returns>

        public static List<Category> GetCategories()
        { return _categories; }

        ///<sumary>
        ///GetProducts: Lấy đối tượng sản phẩm theo Id
        ///</sumary>
        ///<param name="ID"></param>
        ///<returns>Category</returns>
        public static Product1? GetCategoryById(int id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

    }
}
