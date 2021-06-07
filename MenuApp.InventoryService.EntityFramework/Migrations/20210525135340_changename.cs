using Microsoft.EntityFrameworkCore.Migrations;

namespace MenuApp.InventoryService.Persistance.Migrations
{
    public partial class changename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipe_Recipes_IngredientsId1",
                table: "IngredientRecipe");

            migrationBuilder.RenameColumn(
                name: "IngredientsId1",
                table: "IngredientRecipe",
                newName: "RecipesId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipe_IngredientsId1",
                table: "IngredientRecipe",
                newName: "IX_IngredientRecipe_RecipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipe_Recipes_RecipesId",
                table: "IngredientRecipe",
                column: "RecipesId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipe_Recipes_RecipesId",
                table: "IngredientRecipe");

            migrationBuilder.RenameColumn(
                name: "RecipesId",
                table: "IngredientRecipe",
                newName: "IngredientsId1");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientRecipe_RecipesId",
                table: "IngredientRecipe",
                newName: "IX_IngredientRecipe_IngredientsId1");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipe_Recipes_IngredientsId1",
                table: "IngredientRecipe",
                column: "IngredientsId1",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
