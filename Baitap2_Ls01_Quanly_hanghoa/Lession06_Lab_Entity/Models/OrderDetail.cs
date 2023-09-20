namespace Lession06_Lab_Entity.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public string OrderId  { get; set; }
        public string BookId   { get; set; }
        public int Quantity     { get; set; }
        public int Price  { get; set; }
        public int intTotalMoney{ get; set; }

    }
}
