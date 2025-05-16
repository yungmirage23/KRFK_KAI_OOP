using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB_30_31.Data.Migrations
{
    /// <inheritdoc />
    public partial class ColumnsRenameMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_categories_categoryid",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "books",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "books",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "books",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "books",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_books_categoryid",
                table: "books",
                newName: "IX_books_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_books_categories_CategoryId",
                table: "books");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "books",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "books",
                newName: "categoryid");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "books",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "books",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_books_CategoryId",
                table: "books",
                newName: "IX_books_categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_books_categories_categoryid",
                table: "books",
                column: "categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
