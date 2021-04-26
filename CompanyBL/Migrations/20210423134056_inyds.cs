using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyBL.Migrations
{
    public partial class inyds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Vacansies_VacansyId",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacansies_Employees_EmployeeId",
                table: "Vacansies");

            migrationBuilder.DropIndex(
                name: "IX_Vacansies_EmployeeId",
                table: "Vacansies");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Vacansies");

            migrationBuilder.AlterColumn<int>(
                name: "VacansyId",
                table: "Managers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VacansyId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_VacansyId",
                table: "Employees",
                column: "VacansyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Vacansies_VacansyId",
                table: "Employees",
                column: "VacansyId",
                principalTable: "Vacansies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Vacansies_VacansyId",
                table: "Managers",
                column: "VacansyId",
                principalTable: "Vacansies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Vacansies_VacansyId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Vacansies_VacansyId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_VacansyId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "VacansyId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Vacansies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VacansyId",
                table: "Managers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Vacansies_EmployeeId",
                table: "Vacansies",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Vacansies_VacansyId",
                table: "Managers",
                column: "VacansyId",
                principalTable: "Vacansies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacansies_Employees_EmployeeId",
                table: "Vacansies",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
