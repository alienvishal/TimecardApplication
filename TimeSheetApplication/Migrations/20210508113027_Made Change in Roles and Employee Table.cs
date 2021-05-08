using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetApplication.Migrations
{
    public partial class MadeChangeinRolesandEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Roles",
                newName: "RoleID");

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RoleID",
                table: "Employees",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Roles_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Roles_RoleID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RoleID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Roles",
                newName: "ID");
        }
    }
}
