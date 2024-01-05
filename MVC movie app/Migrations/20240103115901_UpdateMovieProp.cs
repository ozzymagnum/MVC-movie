using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_movie_app.Migrations
{
    public partial class UpdateMovieProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Movie",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_UserId",
                table: "Movie",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_UserId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Movie");
        }
    }
}
