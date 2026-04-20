using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class ThemGiaMonAn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gia",
                table: "MonAn");

            migrationBuilder.CreateTable(
                name: "GiaMonAn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaVon = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonAnID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaMonAn", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GiaMonAn_MonAn_MonAnID",
                        column: x => x.MonAnID,
                        principalTable: "MonAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GiaMonAn_MonAnID",
                table: "GiaMonAn",
                column: "MonAnID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiaMonAn");

            migrationBuilder.AddColumn<decimal>(
                name: "Gia",
                table: "MonAn",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
