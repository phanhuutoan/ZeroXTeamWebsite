using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroXTeam.Migrations
{
    public partial class FacebookEmailMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Member",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Member",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Member");
        }
    }
}
