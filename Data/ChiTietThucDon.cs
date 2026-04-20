using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Data
{   public class ChiTietThucDon
    {
    public int ID { get; set; }

    public int ThucDonID { get; set; }
    public ThucDon ThucDon { get; set; }

    public int MonAnID { get; set; }
    public MonAn MonAn { get; set; }
    }
}
