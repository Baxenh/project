namespace Lession06_DbContext_CF.Models.DataModels
{
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
