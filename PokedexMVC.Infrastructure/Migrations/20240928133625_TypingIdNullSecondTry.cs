using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypingIdNullSecondTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "TypingId",
                table: "Pokemons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons",
                column: "TypingId",
                principalTable: "Typings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons");

            migrationBuilder.AlterColumn<int>(
                name: "TypingId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons",
                column: "TypingId",
                principalTable: "Typings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
