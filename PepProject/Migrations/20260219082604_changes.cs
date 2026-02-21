using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PepProject.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "AdminName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "AdminPassword",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "DoctorPassword",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientEmail",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientName",
                table: "RegisteredTable");

            migrationBuilder.DropColumn(
                name: "PatientPassword",
                table: "RegisteredTable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DoctorPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientEmail",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PatientPassword",
                table: "RegisteredTable",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
