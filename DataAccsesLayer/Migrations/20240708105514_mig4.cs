using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccsesLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserProgresses_UserId",
                table: "UserProgresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEducationRelations_UserId",
                table: "UserEducationRelations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEducationRelations_Users_UserId",
                table: "UserEducationRelations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgresses_Users_UserId",
                table: "UserProgresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEducationRelations_Users_UserId",
                table: "UserEducationRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProgresses_Users_UserId",
                table: "UserProgresses");

            migrationBuilder.DropIndex(
                name: "IX_UserProgresses_UserId",
                table: "UserProgresses");

            migrationBuilder.DropIndex(
                name: "IX_UserEducationRelations_UserId",
                table: "UserEducationRelations");
        }
    }
}
