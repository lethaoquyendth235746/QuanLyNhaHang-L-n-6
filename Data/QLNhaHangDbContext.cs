using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhaHang.Data
{
    public class QLNhaHangDbContext :DbContext
    {
        public DbSet<DanhMuc> DanhMuc { get; set; }
        public DbSet<MonAn> MonAn { get; set; }
        public DbSet<Ban> Ban { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<GiaMonAn> GiaMonAn { get; set; }

        public DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public DbSet<ThucDon> ThucDon { get; set; }
        public DbSet<ChiTietThucDon> ChiTietThucDon { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }

        public DbSet<Combo> Combo { get; set; }
        public DbSet<ChiTietCombo> ChiTietCombo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.;Database=QLNhaHang;Trusted_Connection=True; TrustServerCertificate=True;");
        }

    }
}
