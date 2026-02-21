using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace PepProject.Models
{
    public class MedDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-6139Q52\\MSSQLSERVER01;initial catalog=db_Hospitalbase;integrated security=true;trustservercertificate=true");
        }
        public DbSet<RegisterModel> RegisteredTable { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<BookingDoctorModel> BookingDoctorModel_Appointments { get; set; }


    }
}
