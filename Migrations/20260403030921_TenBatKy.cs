using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class TenBatKy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "QuyenHan",
                table: "NhanVien");

            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "VaiTro",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "VaiTroID",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien",
                column: "VaiTroID",
                principalTable: "VaiTro",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "VaiTro");

            migrationBuilder.AlterColumn<int>(
                name: "VaiTroID",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "QuyenHan",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien",
                column: "VaiTroID",
                principalTable: "VaiTro",
                principalColumn: "ID");
        }
    }
}
