namespace Lession07_Lab07_BTTLBai2_NetCore.Models.DataModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
