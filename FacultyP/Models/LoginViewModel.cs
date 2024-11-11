using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FacultyP.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username or Email is required.")]
        [MaxLength(20, ErrorMessage = "Max 50 character allowed")]
        [DisplayName("Username or Email")]
        public string UsernameOrEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Max 50 or Min 5  character allowed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

       
    }
}
