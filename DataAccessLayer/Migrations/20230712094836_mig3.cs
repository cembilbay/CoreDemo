using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Comments_CommentID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CommentID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CommentID",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "BlogID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                column: "BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BlogID",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CommentID",
                table: "Blogs",
                column: "CommentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Comments_CommentID",
                table: "Blogs",
                column: "CommentID",
                principalTable: "Comments",
                principalColumn: "CommentID");
        }
    }
}
