using Microsoft.EntityFrameworkCore.Migrations;

namespace BKD_NetCore_SQLServer.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credit_Card",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    card = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    exp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cvv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit_Card", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Credit_Card");
        }
    }
}
