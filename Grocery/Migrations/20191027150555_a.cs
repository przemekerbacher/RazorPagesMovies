using Microsoft.EntityFrameworkCore.Migrations;

namespace Grocery.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoriesId",
                table: "Products",
                column: "CategoriesId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoriesId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoriesId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
