using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class CustomerOrderModel
    {
        [Key]
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime? OrderDate { get; set; }

        public UserModel User { get; set; }
        public List<OrderDetailModel> OrderDetails { get; set; }
    }
}
