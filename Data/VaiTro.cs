using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class VaiTro
    {
        public int ID { get; set; }
        public string TenVaiTro { get; set; } 
        // Admin, Quản lý, thu ngân, phụ vụ
        public string MoTa { get; set; }
        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
