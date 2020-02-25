using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deskquote",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Drawers = table.Column<int>(nullable: false),
                    DrawerCost = table.Column<int>(nullable: false),
                    Area = table.Column<int>(nullable: false),
                    AreaCost = table.Column<int>(nullable: false),
                    MaterialCost = table.Column<int>(nullable: false),
                    ShippingCost = table.Column<int>(nullable: false),
                    Material = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    Quote = table.Column<double>(nullable: false),
                    Rush = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deskquote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deskquote");
        }
    }
}
