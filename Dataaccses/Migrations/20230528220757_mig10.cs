using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccses.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorCategoryid",
                table: "SendMessages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ColorCategories",
                columns: table => new
                {
                    ColorCategoryid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCategoryid1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorCategories", x => x.ColorCategoryid);
                    table.ForeignKey(
                        name: "FK_ColorCategories_ColorCategories_ColorCategoryid1",
                        column: x => x.ColorCategoryid1,
                        principalTable: "ColorCategories",
                        principalColumn: "ColorCategoryid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SendMessages_ColorCategoryid",
                table: "SendMessages",
                column: "ColorCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_ColorCategories_ColorCategoryid1",
                table: "ColorCategories",
                column: "ColorCategoryid1");

            migrationBuilder.AddForeignKey(
                name: "FK_SendMessages_ColorCategories_ColorCategoryid",
                table: "SendMessages",
                column: "ColorCategoryid",
                principalTable: "ColorCategories",
                principalColumn: "ColorCategoryid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SendMessages_ColorCategories_ColorCategoryid",
                table: "SendMessages");

            migrationBuilder.DropTable(
                name: "ColorCategories");

            migrationBuilder.DropIndex(
                name: "IX_SendMessages_ColorCategoryid",
                table: "SendMessages");

            migrationBuilder.DropColumn(
                name: "ColorCategoryid",
                table: "SendMessages");
        }
    }
}
