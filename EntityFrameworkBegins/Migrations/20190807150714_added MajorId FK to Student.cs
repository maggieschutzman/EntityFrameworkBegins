using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkBegins.Migrations
{
    public partial class addedMajorIdFKtoStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_students_MajorId",
                table: "students",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_majors_MajorId",
                table: "students",
                column: "MajorId",
                principalTable: "majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_majors_MajorId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_MajorId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "students");
        }
    }
}
