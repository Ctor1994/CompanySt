using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyBL.Migrations
{
    public partial class @in : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
