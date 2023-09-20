namespace Lession06_Lab_Entity.Models
{
    public class Book
    {
     public string BookId { get; set; }
     public string Title  { get; set; }
    public string Author { get; set; }
    public int Release { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public int PublisherId { get; set; }
    public int CategoryId { get; set; }

    }
}
