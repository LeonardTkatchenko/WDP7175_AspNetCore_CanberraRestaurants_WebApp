using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_CanberraRestaurants_WebApp.Data.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "canIncreaseAgree",
                table: "ReviewsForum",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "canIncreaseDisagree",
                table: "ReviewsForum",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "canIncreaseAgree",
                table: "ReviewsForum");

            migrationBuilder.DropColumn(
                name: "canIncreaseDisagree",
                table: "ReviewsForum");
        }
    }
}
