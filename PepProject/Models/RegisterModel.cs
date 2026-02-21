using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Role { get; set; }



        // 🔹 Patient Fields (NO Required)
        
        public int Age { get; set; }
        public string? Address { get; set; }

        // 🔹 Doctor Fields (NO Required)
        
        public string? Specialization { get; set; }
        public int Experience { get; set; }

        // 🔹 Admin Field (NO Required)
       
        public string? Department { get; set; }
        
    }
}
