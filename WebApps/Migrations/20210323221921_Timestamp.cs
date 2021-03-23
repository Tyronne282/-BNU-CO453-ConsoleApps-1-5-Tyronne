using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApps.Migrations
{
    public partial class Timestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Posts",
                newName: "Timestamp");
                
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Timestamp",
                table: "Posts",
                newName: "Time");
        }
    }
}
