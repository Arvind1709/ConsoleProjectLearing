using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class OrderModel
    {
        [Key]
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }

        public ICollection<OrderItemModel> OrderItems { get; set; }
    }
}
