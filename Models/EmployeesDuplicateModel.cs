using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleProjectLearing.Models
{
    internal class EmployeesDuplicateModel
    {
        [Key]
        public int EmpID { get; set; }  // Primary Key (Auto-increment)

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }  // Employee Name

        [Required]
        [StringLength(50)]
        public string Department { get; set; }  // Department Name

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Salary { get; set; }  // Salary
    }
}
