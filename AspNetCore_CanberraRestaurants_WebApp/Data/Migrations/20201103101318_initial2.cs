using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_CanberraRestaurants_WebApp.Data.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Agree",
                table: "ReviewsForum",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disagree",
                table: "ReviewsForum",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agree",
                table: "ReviewsForum");

            migrationBuilder.DropColumn(
                name: "Disagree",
                table: "ReviewsForum");
        }
    }
}
