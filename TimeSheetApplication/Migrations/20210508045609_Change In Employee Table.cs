using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetApplication.Migrations
{
    public partial class ChangeInEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "EmpLastName");

            migrationBuilder.AddColumn<string>(
                name: "EmpFirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpFirstName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmpLastName",
                table: "Employees",
                newName: "EmployeeName");
        }
    }
}
