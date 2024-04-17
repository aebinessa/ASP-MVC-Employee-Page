using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Employee_Page.Models
{
    public class AddEmployeeForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }

    }
}
