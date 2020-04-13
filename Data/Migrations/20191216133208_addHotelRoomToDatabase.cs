using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelMVC2019.Data.Migrations
{
    public partial class addHotelRoomToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelMvcs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelNr = table.Column<int>(nullable: false),
                    Navn = table.Column<string>(nullable: false),
                    Adresse = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelMvcs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomMvcs",
                columns: table => new
                {
                    RoomMVCID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelMVCID = table.Column<int>(nullable: false),
                    RoomNr = table.Column<int>(nullable: false),
                    Types = table.Column<string>(nullable: false),
                    Pris = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomMvcs", x => x.RoomMVCID);
                    table.ForeignKey(
                        name: "FK_RoomMvcs_HotelMvcs_HotelMVCID",
                        column: x => x.HotelMVCID,
                        principalTable: "HotelMvcs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomMvcs_HotelMVCID",
                table: "RoomMvcs",
                column: "HotelMVCID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomMvcs");

            migrationBuilder.DropTable(
                name: "HotelMvcs");
        }
    }
}
