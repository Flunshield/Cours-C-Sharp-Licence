using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWeb.Migrations
{
    /// <inheritdoc />
    public partial class changeIdArmsToArmsForEnemys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdHeroesArms",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "IdEnemysArms",
                table: "Enemys");

            migrationBuilder.AddColumn<string>(
                name: "HeroesArms",
                table: "Heroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "EnemysArms",
                table: "Enemys",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeroesArms",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "EnemysArms",
                table: "Enemys");

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
        }
    }
}
