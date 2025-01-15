using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class M5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Produits");

            migrationBuilder.CreateTable(
                name: "cata",
                columns: table => new
                {
                    Pages = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cata", x => x.Pages);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cata");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Produits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
