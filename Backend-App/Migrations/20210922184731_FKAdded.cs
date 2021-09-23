using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_App.Migrations
{
    public partial class FKAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "formateurs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_formateurs_UserId",
                table: "formateurs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_formateurs_users_UserId",
                table: "formateurs",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_formateurs_users_UserId",
                table: "formateurs");

            migrationBuilder.DropIndex(
                name: "IX_formateurs_UserId",
                table: "formateurs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "formateurs");
        }
    }
}
