using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIWeb.Migrations
{
    /// <inheritdoc />
    public partial class testajoutTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "classePlayer",
                table: "Heroes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "classePlayer",
                table: "Heroes");
        }
    }
}
