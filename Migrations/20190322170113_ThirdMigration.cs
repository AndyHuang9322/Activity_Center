using Microsoft.EntityFrameworkCore.Migrations;

namespace Activity_Center.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StarTime",
                table: "Events",
                newName: "StartTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Events",
                newName: "StarTime");
        }
    }
}
