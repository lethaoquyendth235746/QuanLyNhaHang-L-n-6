using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class ChiTietCombo
    {
        public int ID { get; set; }

        public int ComboID { get; set; }
        public Combo Combo { get; set; }

        public int MonAnID { get; set; }
        public MonAn MonAn { get; set; }

        public int SoLuong { get; set; }
    }
}
