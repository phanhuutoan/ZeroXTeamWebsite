using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroXTeam.Migrations
{
    public partial class Information : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomePageInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    SubTitle = table.Column<string>(type: "TEXT", nullable: false),
                    HeroUrl = table.Column<string>(type: "TEXT", nullable: true),
                    HeroPublicId = table.Column<string>(type: "TEXT", nullable: true),
                    AboutUrl = table.Column<string>(type: "TEXT", nullable: true),
                    AboutPublicId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePageInformation");
        }
    }
}
