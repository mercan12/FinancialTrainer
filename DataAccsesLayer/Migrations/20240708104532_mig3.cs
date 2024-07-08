using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsesLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationEduId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_EducationEduId",
                table: "Chapters",
                column: "EducationEduId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Educations_EducationEduId",
                table: "Chapters",
                column: "EducationEduId",
                principalTable: "Educations",
                principalColumn: "EduId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Educations_EducationEduId",
                table: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_EducationEduId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "EducationEduId",
                table: "Chapters");
        }
    }
}
