using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_Typings_TypeId",
                table: "Moves");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeCharacteristics_Typings_TypeRef",
                table: "TypeCharacteristics");

            migrationBuilder.DropTable(
                name: "Typings");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypingId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TypingId",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Moves",
                newName: "MoveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Moves_TypeId",
                table: "Moves",
                newName: "IX_Moves_MoveTypeId");

            migrationBuilder.AddColumn<int>(
                name: "typeComboId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BasicTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeCombinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryTypeId = table.Column<int>(type: "int", nullable: false),
                    SecondaryTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCombinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeCombinations_BasicTypes_PrimaryTypeId",
                        column: x => x.PrimaryTypeId,
                        principalTable: "BasicTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TypeCombinations_BasicTypes_SecondaryTypeId",
                        column: x => x.SecondaryTypeId,
                        principalTable: "BasicTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_typeComboId",
                table: "Pokemons",
                column: "typeComboId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeCombinations_PrimaryTypeId",
                table: "TypeCombinations",
                column: "PrimaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeCombinations_SecondaryTypeId",
                table: "TypeCombinations",
                column: "SecondaryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_BasicTypes_MoveTypeId",
                table: "Moves",
                column: "MoveTypeId",
                principalTable: "BasicTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_TypeCombinations_typeComboId",
                table: "Pokemons",
                column: "typeComboId",
                principalTable: "TypeCombinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeCharacteristics_BasicTypes_TypeRef",
                table: "TypeCharacteristics",
                column: "TypeRef",
                principalTable: "BasicTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moves_BasicTypes_MoveTypeId",
                table: "Moves");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_TypeCombinations_typeComboId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeCharacteristics_BasicTypes_TypeRef",
                table: "TypeCharacteristics");

            migrationBuilder.DropTable(
                name: "TypeCombinations");

            migrationBuilder.DropTable(
                name: "BasicTypes");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_typeComboId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "typeComboId",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "MoveTypeId",
                table: "Moves",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Moves_MoveTypeId",
                table: "Moves",
                newName: "IX_Moves_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "TypingId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Typings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypingId",
                table: "Pokemons",
                column: "TypingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Moves_Typings_TypeId",
                table: "Moves",
                column: "TypeId",
                principalTable: "Typings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons",
                column: "TypingId",
                principalTable: "Typings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeCharacteristics_Typings_TypeRef",
                table: "TypeCharacteristics",
                column: "TypeRef",
                principalTable: "Typings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
