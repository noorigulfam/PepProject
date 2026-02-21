using Microsoft.AspNetCore.Mvc;
using PepProject.Models;

namespace PepProject.Controllers
{
    public class ManagePatientsController : Controller
    {
        public MedDb _db;
        public ManagePatientsController()
        {
            _db = new MedDb();
        }

        public IActionResult MyPatient()
        {
            var res = _db.Patients.ToList();
            return View(res);
        }


        // 📅 Appointment Calendar Page
        public IActionResult AppointmentCalendar()
        {
            return View();
        }


        // ⏰ Manage Availability Page
        public IActionResult ManageAvailability()
        {
            return View();
        }

        public IActionResult BookAppointment()
        {
            var res = _db.Doctors.ToList();
            return View(res);
        }




        [HttpGet]
        public IActionResult BookDoctor(int DoctorId)
        {
            var model = new BookingDoctorModel()
            {
                DoctorID = DoctorId

            };

            return View(model);
        }


        [HttpPost]
        public IActionResult BookDoctor(BookingDoctorModel model)
        {

            // Example: get PatientId from session
            int patientId = Convert.ToInt32(HttpContext.Session.GetInt32("PatientId"));

            model.PatientID = patientId;
            model.Status = "Pending";

            _db.BookingDoctorModel_Appointments.Add(model);
            _db.SaveChanges();

            return RedirectToAction("MyAppointments");


        }


        public IActionResult MyAppointments()
        {
            var data = (from b in _db.BookingDoctorModel_Appointments
                        join d in _db.Doctors on b.DoctorID equals d.DoctorId
                        join p in _db.Patients on b.PatientID equals p.PatientId
                        select new BookingDoctorModel
                        {
                            DoctorName = d.DoctorName,
                            PatientName = p.PatientName,
                            Date = b.Date,
                            Status = b.Status
                        }).ToList();
            return View(data);
        }
    }
}
