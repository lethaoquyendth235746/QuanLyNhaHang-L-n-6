using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnNhanVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "TenNhanVien",
                table: "NhanVien",
                newName: "QuyenHan");

            migrationBuilder.AlterColumn<int>(
                name: "VaiTroID",
                table: "NhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DiaChi",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DienThoai",
                table: "NhanVien",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HoVaTen",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "DiaChi",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "DienThoai",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "HoVaTen",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "QuyenHan",
                table: "NhanVien",
                newName: "TenNhanVien");

            migrationBuilder.AlterColumn<int>(
                name: "VaiTroID",
                table: "NhanVien",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_NhanVien_VaiTro_VaiTroID",
                table: "NhanVien",
                column: "VaiTroID",
                principalTable: "VaiTro",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
