using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyNhaHang.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
      
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public bool TrangThai { get; set; } = true;

        public int VaiTroID { get; set; }
        public VaiTro VaiTro { get; set; }
        public ICollection<DonHang> DonHangs { get; set; }
    }
}
