using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class ThemThucDonVaoCombo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCombo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaCombo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ThucDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThucDon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThuTu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietCombo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComboID = table.Column<int>(type: "int", nullable: false),
                    MonAnID = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietCombo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietCombo_Combo_ComboID",
                        column: x => x.ComboID,
                        principalTable: "Combo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietCombo_MonAn_MonAnID",
                        column: x => x.MonAnID,
                        principalTable: "MonAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietThucDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThucDonID = table.Column<int>(type: "int", nullable: false),
                    MonAnID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietThucDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietThucDon_MonAn_MonAnID",
                        column: x => x.MonAnID,
                        principalTable: "MonAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietThucDon_ThucDon_ThucDonID",
                        column: x => x.ThucDonID,
                        principalTable: "ThucDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCombo_ComboID",
                table: "ChiTietCombo",
                column: "ComboID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietCombo_MonAnID",
                table: "ChiTietCombo",
                column: "MonAnID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThucDon_MonAnID",
                table: "ChiTietThucDon",
                column: "MonAnID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietThucDon_ThucDonID",
                table: "ChiTietThucDon",
                column: "ThucDonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietCombo");

            migrationBuilder.DropTable(
                name: "ChiTietThucDon");

            migrationBuilder.DropTable(
                name: "Combo");

            migrationBuilder.DropTable(
                name: "ThucDon");
        }
    }
}
