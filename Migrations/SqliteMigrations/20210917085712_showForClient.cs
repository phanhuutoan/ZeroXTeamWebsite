using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroXTeam.Migrations
{
    public partial class showForClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowForClient",
                table: "Project",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowForClient",
                table: "Member",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowForClient",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ShowForClient",
                table: "Member");
        }
    }
}
