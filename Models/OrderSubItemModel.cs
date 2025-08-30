using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleProjectLearing.Models
{
    internal class OrderSubItemModel
    {
        [Key]
        public string SubItemId { get; set; }
        [ForeignKey(nameof(OrderItem))]
        public string ItemId { get; set; }
        public string SubItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public OrderItemModel OrderItem { get; set; }
    }
}
