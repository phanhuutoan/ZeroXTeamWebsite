using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroXTeam.Migrations
{
    public partial class MemberTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamTitles",
                table: "Member",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamTitles",
                table: "Member");
        }
    }
}
