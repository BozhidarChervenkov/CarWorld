using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWorld.Migrations
{
    public partial class FixUserMessageMessageContentProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "UserMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "UserMessages");
        }
    }
}
