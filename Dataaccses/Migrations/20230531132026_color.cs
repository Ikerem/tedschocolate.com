using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccses.Migrations
{
    public partial class color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendMessages_ColorCategories_ColorCategoryid",
                table: "SendMessages");

            migrationBuilder.DropIndex(
                name: "IX_SendMessages_ColorCategoryid",
                table: "SendMessages");

            migrationBuilder.DropColumn(
                name: "ColorCategoryid",
                table: "SendMessages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorCategoryid",
                table: "SendMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SendMessages_ColorCategoryid",
                table: "SendMessages",
                column: "ColorCategoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_SendMessages_ColorCategories_ColorCategoryid",
                table: "SendMessages",
                column: "ColorCategoryid",
                principalTable: "ColorCategories",
                principalColumn: "ColorCategoryid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
