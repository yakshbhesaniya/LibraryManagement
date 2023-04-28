using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Publisher",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publisher",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Book",
                newName: "BookTitle");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Author",
                newName: "AuthorName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Author",
                newName: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publisher",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Publisher",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookTitle",
                table: "Book",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Author",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Author",
                newName: "Id");
        }
    }
}
