using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_CanberraRestaurants_WebApp.Data.Migrations
{
    public partial class assignment23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Header",
                table: "ReviewsForum",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "ReviewsForum",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Header",
                table: "ReviewsForum");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "ReviewsForum");
        }
    }
}
