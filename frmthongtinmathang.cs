using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmthongtinmathang : Form
    {
        private int idMonAn;
        public frmthongtinmathang()
        {
            InitializeComponent();
        }
        public frmthongtinmathang(int id)
        {
            InitializeComponent();
            idMonAn = id;
        }

        private void frmthongtinmathang_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ID món ăn là: " + idMonAn);
        }
    }
}
