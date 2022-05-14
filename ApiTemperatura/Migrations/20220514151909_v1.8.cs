using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiTemperatura.Migrations
{
    public partial class v18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreCiudad",
                table: "Temperaturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCiudad",
                table: "Temperaturas");
        }
    }
}
