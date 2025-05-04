using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffylabMVCProject.Migrations
{
    public partial class AddColumnToMeetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Tbl_Meet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Tbl_Meet");
        }
    }
}
