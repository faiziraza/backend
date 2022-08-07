using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryBind2.Migrations
{
    public partial class ABC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "Country_Name",
                table: "Countries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country_Name",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
