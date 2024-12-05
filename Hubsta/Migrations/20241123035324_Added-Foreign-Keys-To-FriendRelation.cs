using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hubsta.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeysToFriendRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User2Id",
                table: "FriendRelations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "User1Id",
                table: "FriendRelations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FriendRelations_User1Id",
                table: "FriendRelations",
                column: "User1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRelations_User2Id",
                table: "FriendRelations",
                column: "User2Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User1Id",
                table: "FriendRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendRelations_AspNetUsers_User2Id",
                table: "FriendRelations");

            migrationBuilder.DropIndex(
                name: "IX_FriendRelations_User1Id",
                table: "FriendRelations");

            migrationBuilder.DropIndex(
                name: "IX_FriendRelations_User2Id",
                table: "FriendRelations");

            migrationBuilder.AlterColumn<string>(
                name: "User2Id",
                table: "FriendRelations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "User1Id",
                table: "FriendRelations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
