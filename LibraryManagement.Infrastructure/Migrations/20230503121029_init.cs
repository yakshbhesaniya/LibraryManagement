using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Publication",
                columns: table => new
                {
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publication", x => x.PublicationId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PublicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Publication_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publication",
                        principalColumn: "PublicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublicationId",
                table: "Book",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Publication");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
