using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB_30_31.Data.Migrations
{
    /// <inheritdoc />
    public partial class TablesRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_books_CategoryId",
                table: "Books",
                newName: "IX_Books_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.RenameIndex(
                name: "IX_Books_CategoryId",
                table: "books",
                newName: "IX_books_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
