using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Entities
{
    [Index(nameof(email),IsUnique = true)]
    [Index(nameof(Username), IsUnique = true)]

    public class UserAccount
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 character allowed")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "email is required.")]
        [MaxLength(100, ErrorMessage = "Max 50 character allowed")]

        public string email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max 50 character allowed")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(20, ErrorMessage = "Max 50 character allowed")]
        public string Password { get; set; }


    }
}
