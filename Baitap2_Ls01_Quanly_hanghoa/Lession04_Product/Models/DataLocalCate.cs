namespace Lession04_Product.Models
{
    public class DataLocalCate
    {
        ///<summary>
        ///Category
        /// </summary>

        public static List<Category> _categories = new List<Category>()
        {
            new Category(){Id=1, Name="Quần áo"},
            new Category(){Id=1, Name="Giày dép"},
            new Category(){Id=1, Name="Laptop"},
            new Category(){Id=1, Name="Điện tử"},
            new Category(){Id=1, Name="Máy bơm"},
        };
        public static List<Category> GetCategory()
        { return _categories; }
        public static Category? GetCategoryById(int id)
        {
            var categories = _categories.FirstOrDefault(x => x.Id == id);
            return categories;
        }
    }
}
