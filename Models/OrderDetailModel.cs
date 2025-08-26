using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class OrderDetailModel
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public CustomerOrderModel CustomerOrder { get; set; }
    }
}
