using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MenuApp.InventoryService.Persistance.Migrations
{
    public partial class seperateInvandNeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.CreateTable(
                name: "IngredientsNeeded",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    AmountNeeded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsNeeded", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientNeededRecipe",
                columns: table => new
                {
                    IngredientsNeededId = table.Column<Guid>(type: "char(36)", nullable: false),
                    RecipesId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientNeededRecipe", x => new { x.IngredientsNeededId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngredientNeededRecipe_IngredientsNeeded_IngredientsNeededId",
                        column: x => x.IngredientsNeededId,
                        principalTable: "IngredientsNeeded",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientNeededRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientNeededRecipe_RecipesId",
                table: "IngredientNeededRecipe",
                column: "RecipesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientNeededRecipe");

            migrationBuilder.DropTable(
                name: "IngredientsNeeded");

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientsId = table.Column<Guid>(type: "char(36)", nullable: false),
                    RecipesId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipesId",
                table: "IngredientRecipe",
                column: "RecipesId");
        }
    }
}
