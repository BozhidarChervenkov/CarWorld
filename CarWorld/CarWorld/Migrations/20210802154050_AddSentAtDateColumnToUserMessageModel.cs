using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWorld.Migrations
{
    public partial class AddSentAtDateColumnToUserMessageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SentAtDate",
                table: "UserMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentAtDate",
                table: "UserMessages");
        }
    }
}
