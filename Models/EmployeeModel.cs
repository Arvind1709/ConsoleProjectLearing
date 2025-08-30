using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentID { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public int? ManagerID { get; set; }

        // Navigation Properties
        public DepartmentModel Department { get; set; }
        public EmployeeModel Manager { get; set; }
        public ICollection<EmployeeModel> Subordinates { get; set; }
    }
}
