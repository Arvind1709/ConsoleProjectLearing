using System.ComponentModel.DataAnnotations;

namespace ConsoleProjectLearing.Models
{
    internal class DepartmentGB
    {
        [Key]
        public int DeptID { get; set; }

        [Required]
        [StringLength(50)]
        public string DeptName { get; set; }

        // Navigation property for related employees
        public ICollection<EmployeeGB> Employees { get; set; } = new List<EmployeeGB>();
    }
}
