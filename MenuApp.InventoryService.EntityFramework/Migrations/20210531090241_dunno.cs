using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MenuApp.InventoryService.Persistance.Migrations
{
    public partial class dunno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientsNeeded_Recipes_RecipeId",
                table: "IngredientsNeeded");

            migrationBuilder.DropIndex(
                name: "IX_IngredientsNeeded_RecipeId",
                table: "IngredientsNeeded");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "IngredientsNeeded");

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

            migrationBuilder.AddColumn<Guid>(
                name: "RecipeId",
                table: "IngredientsNeeded",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsNeeded_RecipeId",
                table: "IngredientsNeeded",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientsNeeded_Recipes_RecipeId",
                table: "IngredientsNeeded",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
