using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PepProject.Migrations
{
    /// <inheritdoc />
    public partial class appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "BookingDoctorModel_Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                table: "BookingDoctorModel_Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "BookingDoctorModel_Appointments");

            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "BookingDoctorModel_Appointments");
        }
    }
}
