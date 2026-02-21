using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class DoctorModel
    {
        [Key]
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string? DoctorName { get; set; }
        public string? DoctorEmail { get; set; }
        public string? DoctorPassword { get; set; }
        public string? Gender { get; set; }
        public string? Specialization { get; set; }
        public int Experience { get; set; }
    }
}
