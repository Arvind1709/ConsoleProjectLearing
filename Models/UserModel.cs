using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class UserModel
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<CustomerOrderModel> CustomerOrders { get; set; }
    }
}
