using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleProjectLearing.Models
{
    internal class EmployeeGB
    {
        [Key]
        public int EmpID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }

        public int DeptID { get; set; }

        public DateTime JoinDate { get; set; }

        // Navigation property for Department
        [ForeignKey("DeptID")]
        public DepartmentGB Department { get; set; }
    }
}
