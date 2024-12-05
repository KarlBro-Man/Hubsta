using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hubsta.Migrations
{
    /// <inheritdoc />
    public partial class AddedOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User1Id",
                table: "FriendRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User2Id",
                table: "FriendRelations");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User1Id",
                table: "FriendRelations",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User2Id",
                table: "FriendRelations",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User1Id",
                table: "FriendRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User2Id",
                table: "FriendRelations");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User1Id",
                table: "FriendRelations",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User2Id",
                table: "FriendRelations",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
