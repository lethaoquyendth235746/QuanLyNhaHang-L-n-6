using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class GiaMonAn
    {
        public int ID { get; set; }

        public string TenGia { get; set; } // VD: Size S, Size L

        public decimal GiaBan { get; set; }
        public decimal GiaVon { get; set; }

        public int MonAnID { get; set; }
        public MonAn MonAn { get; set; }
    }
}
