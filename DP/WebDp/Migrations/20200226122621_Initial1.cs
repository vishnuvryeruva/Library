using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDp.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BTitle = table.Column<string>(nullable: false),
                    BType = table.Column<string>(nullable: true),
                    BPrice = table.Column<double>(nullable: false),
                    BAuthor = table.Column<string>(nullable: false),
                    BPublisher = table.Column<string>(nullable: false),
                    BRelease = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
