using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffylabMVCProject.Migrations
{
    public partial class TestimonialNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestimonialName",
                table: "Tbl_Testimonial",
                newName: "TestimonialTitle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestimonialTitle",
                table: "Tbl_Testimonial",
                newName: "TestimonialName");
        }
    }
}
