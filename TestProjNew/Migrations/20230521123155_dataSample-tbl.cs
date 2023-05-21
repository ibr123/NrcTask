using Microsoft.EntityFrameworkCore.Migrations;

namespace NrcTaskWeb.Migrations
{
    public partial class dataSampletbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Members = table.Column<int>(nullable: false),
                    Divisions = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: true),
                    CaptinName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");
        }
    }
}
