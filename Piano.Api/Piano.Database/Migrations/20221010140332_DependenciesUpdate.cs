using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Piano.Database.Migrations
{
    public partial class DependenciesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_SubscriptionCards_SubscriptionCardId",
                table: "Sessions");

            migrationBuilder.AlterColumn<Guid>(
                name: "SubscriptionCardId",
                table: "Sessions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_SubscriptionCards_SubscriptionCardId",
                table: "Sessions",
                column: "SubscriptionCardId",
                principalTable: "SubscriptionCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_SubscriptionCards_SubscriptionCardId",
                table: "Sessions");

            migrationBuilder.AlterColumn<Guid>(
                name: "SubscriptionCardId",
                table: "Sessions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_SubscriptionCards_SubscriptionCardId",
                table: "Sessions",
                column: "SubscriptionCardId",
                principalTable: "SubscriptionCards",
                principalColumn: "Id");
        }
    }
}
