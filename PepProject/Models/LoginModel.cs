using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class LoginModel
    {
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
