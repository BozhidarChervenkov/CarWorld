using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWorld.Migrations
{
    public partial class UpdatedBodyTypeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "BodyTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "BodyTypes");
        }
    }
}
