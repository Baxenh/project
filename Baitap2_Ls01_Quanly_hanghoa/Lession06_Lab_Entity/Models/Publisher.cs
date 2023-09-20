using System.ComponentModel.DataAnnotations.Schema;

namespace Lession06_Lab_Entity.Models
{
    [Table("Publishers")]
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        //Thuộc tính quan hệ
        public ICollection<Book> Books { get; set; }
    }
}
