using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lession06_DbContext_CF.Models.DataModels
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        //Thuộc tính quan hệ
        public ICollection<Book> Books { get; set; }
    }
}
