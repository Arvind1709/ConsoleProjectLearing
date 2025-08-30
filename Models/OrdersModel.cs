using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class OrdersModel
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
    }
}
