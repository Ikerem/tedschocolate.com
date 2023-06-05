using Microsoft.EntityFrameworkCore.Migrations;

namespace Dataaccses.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "homepages",
                columns: table => new
                {
                    Homepageid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homepages", x => x.Homepageid);
                });

            migrationBuilder.CreateTable(
                name: "OurChocolates",
                columns: table => new
                {
                    OurChocolatesid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    titlesmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptionsmall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurChocolates", x => x.OurChocolatesid);
                });

            migrationBuilder.CreateTable(
                name: "SendMessages",
                columns: table => new
                {
                    SendMessageid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    piece = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filling = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendMessages", x => x.SendMessageid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "homepages");

            migrationBuilder.DropTable(
                name: "OurChocolates");

            migrationBuilder.DropTable(
                name: "SendMessages");
        }
    }
}
