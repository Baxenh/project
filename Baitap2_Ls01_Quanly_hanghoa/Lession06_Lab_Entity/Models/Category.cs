namespace Lession06_Lab_Entity.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public byte Status { get; set; }
        public DateTime CreateDate { get; set; }
        //danh sách sản phẩm theo danh mục
        public ICollection<Category> Categories { get; set; }

    }
}
