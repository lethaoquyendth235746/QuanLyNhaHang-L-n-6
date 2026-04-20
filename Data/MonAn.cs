using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{
    public class MonAn
    {
        public int ID { get; set; }
        public string TenMon { get; set; }

        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        public bool TrangThai { get; set; }

        public int DanhMucID { get; set; }
        public DanhMuc DanhMuc { get; set; }
        public string DonViTinh { get; set; }

        public ICollection<GiaMonAn> GiaMonAns { get; set; }
    }
}
