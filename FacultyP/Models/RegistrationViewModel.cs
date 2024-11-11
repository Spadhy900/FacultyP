using System.ComponentModel.DataAnnotations;

namespace FacultyP.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "email is required.")]
        [MaxLength(100, ErrorMessage = "Max 50 character allowed")]
        //[EmailAddress(ErrorMessage = "Please enter valid email.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max 50 character allowed")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20,MinimumLength = 5,  ErrorMessage = "Max 50 or Min 5  character allowed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
