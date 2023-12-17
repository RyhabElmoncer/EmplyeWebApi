using System.ComponentModel.DataAnnotations;

namespace EmpolyeeWebAPI.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]

        public String FirstName { get; set; }

        [Required]
        public String LastName  { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentID { get; set; }
        public String PhotoPath { get; set; }
        public Department Department { get; set; }



    }
}
