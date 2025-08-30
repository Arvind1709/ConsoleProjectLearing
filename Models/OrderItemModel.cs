using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleProjectLearing.Models
{
    internal class OrderItemModel
    {
        [Key]
        public string ItemId { get; set; }
        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderModel Order { get; set; }
        public ICollection<OrderSubItemModel> OrderSubItems { get; set; }
    }
}
