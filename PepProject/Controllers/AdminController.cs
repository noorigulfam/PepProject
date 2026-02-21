using Microsoft.AspNetCore.Mvc;
using PepProject.Models;

namespace PepProject.Controllers
{
    public class AdminController : Controller
    {
        public MedDb _db;
        public AdminController()
        {
            _db = new MedDb();
        }

        public IActionResult AllAppointments()
        {
            var data = (from b in _db.BookingDoctorModel_Appointments
                        join d in _db.Doctors on b.DoctorID equals d.DoctorId
                        join p in _db.Patients on b.PatientID equals p.PatientId
                        select new BookingDoctorModel
                        {
                            ID = b.ID,
                            DoctorName = d.DoctorName,
                            PatientName = p.PatientName,
                            Date = b.Date,
                            Status = b.Status
                        }).ToList();

            return View(data);
        }


        [HttpGet]
       
        public IActionResult Approve(int id)
        {
            var booking = _db.BookingDoctorModel_Appointments.FirstOrDefault(x => x.ID == id);

            if (booking != null)
            {
                booking.Status = "Approved";
                _db.SaveChanges();
            }

            return RedirectToAction("AllAppointments");
        }

        public IActionResult Reject(int id)
        {
            var booking = _db.BookingDoctorModel_Appointments.FirstOrDefault(x => x.ID == id);

            if (booking != null)
            {
                booking.Status = "Rejected";
                _db.SaveChanges();
            }

            return RedirectToAction("AllAppointments");
        }
    }
}
