using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class ThucDon
    {
        public int ID { get; set; }
        public string TenThucDon { get; set; }
        public int ThuTu { get; set; }

        public ICollection<ChiTietThucDon> ChiTietThucDons { get; set; }
    }
}
