using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class PatientModel
    {
        [Key]
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public string? PatientName { get; set; }
        public string? PatientEmail { get; set; }
        public string? PatientPassword { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
    }
}
