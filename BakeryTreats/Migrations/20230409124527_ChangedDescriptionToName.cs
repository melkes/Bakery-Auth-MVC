using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryTreats.Migrations
{
    public partial class ChangedDescriptionToName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Treats",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Treats",
                newName: "Description");
        }
    }
}
