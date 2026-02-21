using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PepProject.Migrations
{
    /// <inheritdoc />
    public partial class email : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientEmail",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PatientPassword",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorEmail",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorPassword",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminEmail",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorPassword",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientPassword",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientEmail",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PatientPassword",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorEmail",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "DoctorPassword",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AdminEmail",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "Admins");
        }
    }
}
