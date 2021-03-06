using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyBL.Migrations
{
    public partial class sidf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Vacansies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vacansies_DepartmentId",
                table: "Vacansies",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacansies_Departments_DepartmentId",
                table: "Vacansies",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacansies_Departments_DepartmentId",
                table: "Vacansies");

            migrationBuilder.DropIndex(
                name: "IX_Vacansies_DepartmentId",
                table: "Vacansies");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Vacansies");
        }
    }
}
