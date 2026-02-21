using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class AdminModel
    {
        [Key]
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public string? Gender { get; set; }
        public string? AdminName { get; set; }
        public string? AdminEmail { get; set; }
        public string? AdminPassword { get; set; }
        public string? Department { get; set; }
    }

}
