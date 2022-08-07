using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal_2.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    cntId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.cntId);
                });

            migrationBuilder.CreateTable(
                name: "userDatas",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Country2 = table.Column<string>(nullable: true),
                    State2 = table.Column<string>(nullable: true),
                    City2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDatas", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "state2s",
                columns: table => new
                {
                    stId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(nullable: true),
                    countryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state2s", x => x.stId);
                    table.ForeignKey(
                        name: "FK_state2s_countries_countryId",
                        column: x => x.countryId,
                        principalTable: "countries",
                        principalColumn: "cntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "city2s",
                columns: table => new
                {
                    ctId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    stateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city2s", x => x.ctId);
                    table.ForeignKey(
                        name: "FK_city2s_state2s_stateId",
                        column: x => x.stateId,
                        principalTable: "state2s",
                        principalColumn: "stId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_city2s_stateId",
                table: "city2s",
                column: "stateId");

            migrationBuilder.CreateIndex(
                name: "IX_state2s_countryId",
                table: "state2s",
                column: "countryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city2s");

            migrationBuilder.DropTable(
                name: "userDatas");

            migrationBuilder.DropTable(
                name: "state2s");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
