using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWeb.Migrations
{
    /// <inheritdoc />
    public partial class newIdarms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdHeroesArms",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEnemysArms",
                table: "Enemys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEnemysArms",
                table: "Arms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdHeroesArms",
                table: "Arms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHeroesArms",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "IdEnemysArms",
                table: "Enemys");

            migrationBuilder.DropColumn(
                name: "IdEnemysArms",
                table: "Arms");

            migrationBuilder.DropColumn(
                name: "IdHeroesArms",
                table: "Arms");
        }
    }
}
