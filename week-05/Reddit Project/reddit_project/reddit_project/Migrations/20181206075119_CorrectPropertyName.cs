using Microsoft.EntityFrameworkCore.Migrations;

namespace reddit_project.Migrations
{
    public partial class CorrectPropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDateTimeTime",
                table: "Posts",
                newName: "CreateDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDateTime",
                table: "Posts",
                newName: "CreateDateTimeTime");
        }
    }
}
