using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend_App.Migrations
{
    public partial class addtableFormateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "formateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    fullname = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    phonenumber = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formateurs", x => x.Id);
                });

             
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "formateurs");

           
        }
    }
}
