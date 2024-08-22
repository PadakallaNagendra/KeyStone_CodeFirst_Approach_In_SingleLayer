using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KeyStone_CodeFirst_Approach_In_SingleLayer.Migrations
{
    public partial class INITIAL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    vat = table.Column<int>(type: "int", nullable: false),
                    maxPersons = table.Column<int>(type: "int", nullable: false),
                    checkOut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    checkIn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
