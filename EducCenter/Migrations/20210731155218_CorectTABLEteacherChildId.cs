using Microsoft.EntityFrameworkCore.Migrations;

namespace EducCenter.Migrations
{
    public partial class CorectTABLEteacherChildId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherCourses_Students_StudentId",
                table: "TeacherCourses");

            migrationBuilder.DropIndex(
                name: "IX_TeacherCourses_StudentId",
                table: "TeacherCourses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "TeacherCourses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "TeacherCourses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourses_StudentId",
                table: "TeacherCourses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherCourses_Students_StudentId",
                table: "TeacherCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
