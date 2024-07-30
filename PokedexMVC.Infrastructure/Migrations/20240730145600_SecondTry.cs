using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Spped",
                table: "Statistics",
                newName: "Speed");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PokemonDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TypeCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeCharacteristics_Typings_TypeRef",
                        column: x => x.TypeRef,
                        principalTable: "Typings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TypeCharacteristics_TypeRef",
                table: "TypeCharacteristics",
                column: "TypeRef",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeCharacteristics");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PokemonDescriptions");

            migrationBuilder.RenameColumn(
                name: "Speed",
                table: "Statistics",
                newName: "Spped");
        }
    }
}
