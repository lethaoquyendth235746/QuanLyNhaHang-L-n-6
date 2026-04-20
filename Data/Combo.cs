using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class Combo
    {
        public int ID { get; set; }
        public string TenCombo { get; set; }
        public decimal GiaCombo { get; set; }

        public ICollection<ChiTietCombo> ChiTietCombos { get; set; }
    }
}
