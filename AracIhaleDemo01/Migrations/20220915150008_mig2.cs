using Microsoft.EntityFrameworkCore.Migrations;

namespace AracIhaleDemo01.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TramerAciklama",
                table: "Tramer",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TramerAciklama",
                table: "Tramer");
        }
    }
}
