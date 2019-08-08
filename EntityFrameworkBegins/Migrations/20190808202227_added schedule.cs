using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkBegins.Migrations
{
    public partial class addedschedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MajorId",
                table: "courses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Instructor",
                table: "courses",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false),
                    MajorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_schedule_majors_MajorId",
                        column: x => x.MajorId,
                        principalTable: "majors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_MajorId",
                table: "courses",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_MajorId",
                table: "schedule",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_majors_MajorId",
                table: "courses",
                column: "MajorId",
                principalTable: "majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_majors_MajorId",
                table: "courses");

            migrationBuilder.DropTable(
                name: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_courses_MajorId",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "courses");

            migrationBuilder.AlterColumn<int>(
                name: "MajorId",
                table: "courses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Instructor",
                table: "courses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
