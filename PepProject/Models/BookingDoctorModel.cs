using System.ComponentModel.DataAnnotations;

namespace PepProject.Models
{
    public class BookingDoctorModel

    {
        [Key]
        public int ID { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }

        public int DoctorID { get; set; }

        public int PatientID { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
