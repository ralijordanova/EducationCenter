using Microsoft.EntityFrameworkCore.Migrations;

namespace EducCenter.Migrations
{
    public partial class addingINteacherCHILDID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Students_StudentId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_StudentId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "ChildIdId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ChildIdId",
                table: "Teachers",
                column: "ChildIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_ChildIdId",
                table: "Teachers",
                column: "ChildIdId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Students_ChildIdId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ChildIdId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "ChildIdId",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_StudentId",
                table: "Teachers",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Students_StudentId",
                table: "Teachers",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
