using Microsoft.AspNetCore.Mvc;
using PepProject.Models;

namespace PepProject.Controllers
{
    public class ManageDoctorsController : Controller
    {

        public MedDb _db;
        public ManageDoctorsController() {
            _db = new MedDb();
        }
        public IActionResult DoctorsList()
        {
            var res = _db.Doctors.ToList();
            return View(res);
        }

        public IActionResult PatientsList()
        {
            var res = _db.Patients.ToList();
            return View(res);
        }
    }
}
