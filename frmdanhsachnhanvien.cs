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
    public partial class frmdanhsachnhanvien : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        public frmdanhsachnhanvien()
        {
            InitializeComponent();
        }

        private void frmdanhsachnhanvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // LOAD DATA
        public void LoadData(string keyword = "")
        {
            var ds = context.NhanVien
                .Select(nv => new
                {
                    nv.ID,
                    nv.TenDangNhap,
                    nv.HoVaTen,
                    nv.DienThoai,
                    VaiTro = nv.VaiTro.TenVaiTro,
                    TrangThai = nv.TrangThai ? "Hoạt động" : "Khóa"
                })
                .ToList();

            if (!string.IsNullOrEmpty(keyword))
            {
                ds = ds.Where(x =>
                    x.HoVaTen.ToLower().Contains(keyword.ToLower()) ||
                    x.TenDangNhap.ToLower().Contains(keyword.ToLower())
                ).ToList();
            }

            dgvNhanVien.DataSource = ds;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmthemnhanvien f = new frmthemnhanvien();
            f.Owner = this;
            f.ShowDialog();

            LoadData(); // reload sau khi thêm
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvNhanVien.Rows[e.RowIndex].Cells["ID"].Value);

            // Hỏi trước khi đổi
            DialogResult r = MessageBox.Show("Đổi trạng thái nhân viên này?",
                "Xác nhận", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                var nv = context.NhanVien.Find(id);
                nv.TrangThai = !nv.TrangThai;
                context.SaveChanges();

                LoadData();
            }
        }
    }
}
