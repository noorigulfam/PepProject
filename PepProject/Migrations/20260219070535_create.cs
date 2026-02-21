using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PepProject.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PatientName",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AdminName",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "Admins");
        }
    }
}
