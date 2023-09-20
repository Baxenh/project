using Microsoft.Identity.Client;
using System;

namespace Lession06_Lab_Entity.Models
{
    public class OrderBook
    {
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    public string AccountId { get; set; }
        public string ReceiveAddress { get; set; }
        public string ReceivePhone { get; set; }
        public DateTime OrderReceive  { get; set; }
        public string Note { get; set; }
    public string Status { get; set; }
    }
}
