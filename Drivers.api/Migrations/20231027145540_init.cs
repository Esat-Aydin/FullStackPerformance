using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    surname = table.Column<string>(type: "TEXT", nullable: false),
                    ranking = table.Column<int>(type: "INTEGER", nullable: true),
                    points = table.Column<int>(type: "INTEGER", nullable: true),
                    lastRace = table.Column<int>(type: "INTEGER", nullable: true),
                    wins = table.Column<int>(type: "INTEGER", nullable: true),
                    poles = table.Column<int>(type: "INTEGER", nullable: true),
                    bestPosition = table.Column<int>(type: "INTEGER", nullable: true),
                    bestPositionTimes = table.Column<int>(type: "INTEGER", nullable: true),
                    nationality = table.Column<string>(type: "TEXT", nullable: false),
                    team = table.Column<string>(type: "TEXT", nullable: false),
                    teamPoints = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
