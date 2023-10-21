using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drivers.api.Migrations
{
    /// <inheritdoc />
    public partial class DriverAndCarsModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    model = table.Column<string>(type: "TEXT", nullable: true),
                    year = table.Column<int>(type: "INTEGER", nullable: true),
                    color = table.Column<string>(type: "TEXT", nullable: true),
                    licensePlate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

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
                    teamPoints = table.Column<int>(type: "INTEGER", nullable: true),
                    carId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_carId",
                table: "Drivers",
                column: "carId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
