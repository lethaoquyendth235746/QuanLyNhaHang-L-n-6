using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using QuanLyNhaHang.Data;

namespace QuanLyNhaHang
{
    public partial class frmdanhsachkhachhang : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();

        public frmdanhsachkhachhang()
        {
            InitializeComponent();
        }


        private void frmdanhsachkhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // LOAD DATA
        public void LoadData(string keyword = "")
        {
            var ds = context.KhachHang
                .Select(kh => new
                {
                    kh.ID,
                    kh.HoVaTen,
                    kh.DienThoai,
                    TrangThai = kh.TrangThai ? "Hoạt động" : "Khóa"
                })
                .ToList();

            if (!string.IsNullOrEmpty(keyword))
            {
                ds = ds.Where(x =>
                    x.HoVaTen.ToLower().Contains(keyword.ToLower()) ||
                    x.DienThoai.Contains(keyword)
                ).ToList();
            }

            dgvKhacHang.DataSource = ds;
            // Đổi tên cột hiển thị tiếng Việt
            dgvKhacHang.Columns["ID"].HeaderText = "Mã KH";
            dgvKhacHang.Columns["HoVaTen"].HeaderText = "Họ và tên";
            dgvKhacHang.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvKhacHang.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmthemkhachhang f = new frmthemkhachhang();
            f.Owner = this;
            f.ShowDialog();

            LoadData(); // reload lại
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text);
        }

        private void dgvKhacHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(
               dgvKhacHang.Rows[e.RowIndex].Cells["ID"].Value);

            DialogResult r = MessageBox.Show(
                "Đổi trạng thái khách hàng này?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                var kh = context.KhachHang.Find(id);
                kh.TrangThai = !kh.TrangThai;
                context.SaveChanges();

                LoadData();
            }
        }
    }
}
