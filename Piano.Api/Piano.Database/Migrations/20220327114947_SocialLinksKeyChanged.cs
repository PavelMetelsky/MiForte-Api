using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Piano.Database.Migrations
{
    public partial class SocialLinksKeyChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "SocialLinks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks",
                column: "Link");

            migrationBuilder.CreateIndex(
                name: "IX_SocialLinks_UserUserId",
                table: "SocialLinks",
                column: "UserUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialLinks_Users_UserUserId",
                table: "SocialLinks",
                column: "UserUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialLinks_Users_UserUserId",
                table: "SocialLinks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks");

            migrationBuilder.DropIndex(
                name: "IX_SocialLinks_UserUserId",
                table: "SocialLinks");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "SocialLinks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialLinks",
                table: "SocialLinks",
                column: "UserUserId");
        }
    }
}
