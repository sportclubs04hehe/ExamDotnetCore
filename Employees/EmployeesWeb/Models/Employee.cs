using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeesWeb.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [Required]
        [StringLength(60)]
        [Display(Name = "Employee Name")]
        public String EmployeeName { get; set; }
        [Required]
        public String Department { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public double Salary { get; set; }
    }
}
