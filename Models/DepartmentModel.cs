using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class DepartmentModel
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        // Navigation Property (Optional)
        public ICollection<EmployeeModel> Employees { get; set; }
    }
}
