using Microsoft.EntityFrameworkCore.Migrations;

namespace projectMigration.Migrations
{
    public partial class columnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "respcode",
                schema: "EFCOREPOC",
                table: "FINS_3IN1APPREQUEST",
                type: "NVARCHAR2(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "respcode",
                schema: "EFCOREPOC",
                table: "FINS_3IN1APPREQUEST");
        }
    }
}
