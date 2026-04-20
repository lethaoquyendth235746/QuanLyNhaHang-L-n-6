using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class Ban
    {
        public int ID { get; set; }
        public string TenBan { get; set; }   // Bàn 1, Bàn 2
        public int SoChoNgoi { get; set; }   // 2 người, 4 người
        public bool TrangThai { get; set; }  // có thể bỏ (xem bước 5)

        public ICollection<DonHang> DonHangs { get; set; }
    }
}
