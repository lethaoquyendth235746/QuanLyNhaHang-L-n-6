using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang.Data;

namespace QuanLyNhaHang
{
    public partial class frmthemkhachhang : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        public frmthemkhachhang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập điện thoại!");
                return;
            }

            try
            {
                KhachHang kh = new KhachHang
                {
                    HoVaTen = txtHoTen.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    TrangThai = true
                };

                context.KhachHang.Add(kh);
                context.SaveChanges();

                MessageBox.Show("Thêm khách hàng thành công!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        private void labQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmthemkhachhang_Load(object sender, EventArgs e)
        {
            txtHoTen.Focus();
        }
    }
}
