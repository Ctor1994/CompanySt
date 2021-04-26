using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyBL.Migrations
{
    public partial class iny : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacansies_Managers_ManagerId",
                table: "Vacansies");

            migrationBuilder.DropTable(
                name: "EmployeeVacansy");

            migrationBuilder.DropIndex(
                name: "IX_Vacansies_ManagerId",
                table: "Vacansies");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Vacansies");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Vacansies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VacansyId",
                table: "Managers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacansies_EmployeeId",
                table: "Vacansies",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_VacansyId",
                table: "Managers",
                column: "VacansyId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Managers_VacansyId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Vacansies");

            migrationBuilder.DropColumn(
                name: "VacansyId",
                table: "Managers");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Vacansies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeeVacansy",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    VacansiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeVacansy", x => new { x.EmployeesId, x.VacansiesId });
                    table.ForeignKey(
                        name: "FK_EmployeeVacansy_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeVacansy_Vacansies_VacansiesId",
                        column: x => x.VacansiesId,
                        principalTable: "Vacansies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vacansies_ManagerId",
                table: "Vacansies",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeVacansy_VacansiesId",
                table: "EmployeeVacansy",
                column: "VacansiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacansies_Managers_ManagerId",
                table: "Vacansies",
                column: "ManagerId",
                principalTable: "Managers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
