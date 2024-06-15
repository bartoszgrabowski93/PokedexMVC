using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokedexMVC.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTypings_Pokemons_PokemonId",
                table: "PokemonTypings");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTypings_Typings_TypingId",
                table: "PokemonTypings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonTypings",
                table: "PokemonTypings");

            migrationBuilder.RenameTable(
                name: "PokemonTypings",
                newName: "PokemonTyping");

            migrationBuilder.RenameColumn(
                name: "TypingId",
                table: "PokemonTyping",
                newName: "PrimaryTypeId");

            migrationBuilder.RenameColumn(
                name: "PokemonId",
                table: "PokemonTyping",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonTypings_TypingId",
                table: "PokemonTyping",
                newName: "IX_PokemonTyping_PrimaryTypeId");

            migrationBuilder.AddColumn<int>(
                name: "PokemonTypingId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypingId",
                table: "Pokemons",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PokemonTyping",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PokemonTyping",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SecondaryTypeId",
                table: "PokemonTyping",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonTyping",
                table: "PokemonTyping",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbEffect = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonEvolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonRef = table.Column<int>(type: "int", nullable: false),
                    PrevEvolutionId = table.Column<int>(type: "int", nullable: true),
                    PrevPokemonId = table.Column<int>(type: "int", nullable: true),
                    NextEvolutionId = table.Column<int>(type: "int", nullable: true),
                    NextPokemonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonEvolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonEvolutions_Pokemons_NextEvolutionId",
                        column: x => x.NextEvolutionId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokemonEvolutions_Pokemons_PokemonRef",
                        column: x => x.PokemonRef,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonEvolutions_Pokemons_PrevEvolutionId",
                        column: x => x.PrevEvolutionId,
                        principalTable: "Pokemons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PokemonAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonId = table.Column<int>(type: "int", nullable: false),
                    PrimaryAbilityId = table.Column<int>(type: "int", nullable: false),
                    SecondaryAbilityId = table.Column<int>(type: "int", nullable: true),
                    HiddenAbilityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Ability_HiddenAbilityId",
                        column: x => x.HiddenAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Ability_PrimaryAbilityId",
                        column: x => x.PrimaryAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Ability_SecondaryAbilityId",
                        column: x => x.SecondaryAbilityId,
                        principalTable: "Ability",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PokemonAbilities_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonTypingId",
                table: "Pokemons",
                column: "PokemonTypingId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypingId",
                table: "Pokemons",
                column: "TypingId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTyping_SecondaryTypeId",
                table: "PokemonTyping",
                column: "SecondaryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_HiddenAbilityId",
                table: "PokemonAbilities",
                column: "HiddenAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_PokemonId",
                table: "PokemonAbilities",
                column: "PokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_PrimaryAbilityId",
                table: "PokemonAbilities",
                column: "PrimaryAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonAbilities_SecondaryAbilityId",
                table: "PokemonAbilities",
                column: "SecondaryAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEvolutions_NextEvolutionId",
                table: "PokemonEvolutions",
                column: "NextEvolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEvolutions_PokemonRef",
                table: "PokemonEvolutions",
                column: "PokemonRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonEvolutions_PrevEvolutionId",
                table: "PokemonEvolutions",
                column: "PrevEvolutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTyping_PokemonTypingId",
                table: "Pokemons",
                column: "PokemonTypingId",
                principalTable: "PokemonTyping",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons",
                column: "TypingId",
                principalTable: "Typings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTyping_Typings_PrimaryTypeId",
                table: "PokemonTyping",
                column: "PrimaryTypeId",
                principalTable: "Typings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTyping_Typings_SecondaryTypeId",
                table: "PokemonTyping",
                column: "SecondaryTypeId",
                principalTable: "Typings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTyping_PokemonTypingId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Typings_TypingId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTyping_Typings_PrimaryTypeId",
                table: "PokemonTyping");

            migrationBuilder.DropForeignKey(
                name: "FK_PokemonTyping_Typings_SecondaryTypeId",
                table: "PokemonTyping");

            migrationBuilder.DropTable(
                name: "PokemonAbilities");

            migrationBuilder.DropTable(
                name: "PokemonEvolutions");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PokemonTypingId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TypingId",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PokemonTyping",
                table: "PokemonTyping");

            migrationBuilder.DropIndex(
                name: "IX_PokemonTyping_SecondaryTypeId",
                table: "PokemonTyping");

            migrationBuilder.DropColumn(
                name: "PokemonTypingId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TypingId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PokemonTyping");

            migrationBuilder.DropColumn(
                name: "SecondaryTypeId",
                table: "PokemonTyping");

            migrationBuilder.RenameTable(
                name: "PokemonTyping",
                newName: "PokemonTypings");

            migrationBuilder.RenameColumn(
                name: "PrimaryTypeId",
                table: "PokemonTypings",
                newName: "TypingId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PokemonTypings",
                newName: "PokemonId");

            migrationBuilder.RenameIndex(
                name: "IX_PokemonTyping_PrimaryTypeId",
                table: "PokemonTypings",
                newName: "IX_PokemonTypings_TypingId");

            migrationBuilder.AlterColumn<int>(
                name: "PokemonId",
                table: "PokemonTypings",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PokemonTypings",
                table: "PokemonTypings",
                columns: new[] { "PokemonId", "TypingId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTypings_Pokemons_PokemonId",
                table: "PokemonTypings",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PokemonTypings_Typings_TypingId",
                table: "PokemonTypings",
                column: "TypingId",
                principalTable: "Typings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
