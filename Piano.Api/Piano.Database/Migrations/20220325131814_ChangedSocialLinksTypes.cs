using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Piano.Database.Migrations
{
    public partial class ChangedSocialLinksTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserUserId",
                table: "SocialLinks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SocialLinks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialLinks_UserId",
                table: "SocialLinks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialLinks_Users_UserId",
                table: "SocialLinks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialLinks_Users_UserId",
                table: "SocialLinks");

            migrationBuilder.DropIndex(
                name: "IX_SocialLinks_UserId",
                table: "SocialLinks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SocialLinks");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserUserId",
                table: "SocialLinks",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
