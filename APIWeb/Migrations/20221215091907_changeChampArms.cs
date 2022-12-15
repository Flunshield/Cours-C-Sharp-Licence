using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWeb.Migrations
{
    /// <inheritdoc />
    public partial class changeChampArms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEnemysArms",
                table: "Arms");

            migrationBuilder.DropColumn(
                name: "IdHeroesArms",
                table: "Arms");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Arms",
                newName: "HeroesNameArms");

            migrationBuilder.AddColumn<string>(
                name: "EnemysNameArms",
                table: "Arms",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnemysNameArms",
                table: "Arms");

            migrationBuilder.RenameColumn(
                name: "HeroesNameArms",
                table: "Arms",
                newName: "name");

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
    }
}
