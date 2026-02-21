using Microsoft.AspNetCore.Mvc;
using PepProject.Models;
using System.Numerics;

namespace PepProject.Controllers
{
    public class HomePageController : Controller
    {
        public MedDb _medicaldb;
        public HomePageController()
        {
            _medicaldb = new MedDb();
        }



        public IActionResult HomePage()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel obj)
        {
            if (ModelState.IsValid)
            {
                //if (obj.Email == "admin@yahoo.com" && obj.Password == "admin")
                //{
                //    return RedirectToAction("AdminHomePage");
                //}
                //else
                //{
                //    var res = _medicaldb.RegisteredTable.Any(x => x.Email == obj.Email && x.Password == obj.Password);
                //    if (res)
                //    {
                //        return RedirectToAction("PatientHomePage");
                //    }
                //}

                if (obj.Type == "Admin")
                {

                    var admin = _medicaldb.Admins
                .FirstOrDefault(x => x.AdminEmail == obj.Email && x.AdminPassword == obj.Password);


                    HttpContext.Session.SetInt32("AdminId", admin.AdminId);
                    if (admin != null)
                    {
                        return RedirectToAction("AdminDashboard");
                    }
                }

                else if (obj.Type == "Doctor")
                {

                    var doctor = _medicaldb.Doctors
                .FirstOrDefault(x => x.DoctorEmail == obj.Email && x.DoctorPassword == obj.Password);


                    HttpContext.Session.SetInt32("DoctorId", doctor.DoctorId);
                    if (doctor != null)
                    {
                        return RedirectToAction("DoctorDashboard");
                    }
                }

                else if (obj.Type == "Patient")
                {
                    var patient = _medicaldb.Patients
              .FirstOrDefault(x => x.PatientEmail == obj.Email && x.PatientPassword == obj.Password);


                    HttpContext.Session.SetInt32("PatientId", patient.PatientId);
                    if (patient != null)
                    {
                        return RedirectToAction("PatientDashboard");
                    }
                }
            }
            return View();
        }





        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel obj)
        {
            // Remove validation for non-related fields
            if (obj.Role == "Patient")
            {
                ModelState.Remove("Specialization");
                ModelState.Remove("Experience");
                ModelState.Remove("Department");
                //Age Address
            }

            if (obj.Role == "Doctor")
            {
                ModelState.Remove("Department");
                ModelState.Remove("Age");
                ModelState.Remove("Address");

                //Exp , Spec

            }

            if (obj.Role == "Admin")
            {
                ModelState.Remove("Age");
                ModelState.Remove("Address");
                ModelState.Remove("Specialization");
                ModelState.Remove("Experience");
            }

            if (ModelState.IsValid)
            {
                // 1️⃣ Save Common User Data
                //  _medicaldb.RegisteredTable.Add(obj);
                //   _medicaldb.SaveChanges();   // Now obj.Id gets generated

                // 2️⃣ Save Role Specific Data
                if (obj.Role == "Patient")
                {
                    PatientModel patient = new PatientModel()
                    {
                        UserId = obj.Id,
                        PatientName = obj.FullName,
                        Gender = obj.Gender,
                        Age = obj.Age,
                        Address = obj.Address,
                        PatientEmail = obj.Email,
                        PatientPassword = obj.Password
                    };

                    _medicaldb.Patients.Add(patient);
                }
                else if (obj.Role == "Doctor")
                {
                    DoctorModel doctor = new DoctorModel()
                    {
                        UserId = obj.Id,
                        DoctorName = obj.FullName,
                        Gender = obj.Gender,
                        Specialization = obj.Specialization,
                        Experience = obj.Experience,
                        DoctorEmail = obj.Email,
                        DoctorPassword = obj.Password

                    };

                    _medicaldb.Doctors.Add(doctor);
                }
                else if (obj.Role == "Admin")
                {
                    AdminModel admin = new AdminModel()
                    {
                        UserId = obj.Id,
                        AdminName = obj.FullName,
                        Gender = obj.Gender,
                        AdminEmail = obj.Email,
                        AdminPassword = obj.Password,
                        Department = obj.Department
                    };

                    _medicaldb.Admins.Add(admin);
                }

                _medicaldb.SaveChanges();

                return RedirectToAction("Login");
            }

            return View(obj);
        }






        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult EmergencyCare()
        {
            return View();
        }



        public IActionResult AdminDashboard()
        {
            return View();
        }

        public IActionResult DoctorDashboard()
        {
            return View();
        }

        public IActionResult PatientDashboard()
        {
            return View();
        }


    }
}
