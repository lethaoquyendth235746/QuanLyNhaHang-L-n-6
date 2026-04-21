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
    public partial class frmban : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        int idDangChon = -1;
        public frmban()
        {
            InitializeComponent();
        }
        private void LoadBan()
        {
            dgvBan.DataSource = context.Ban
                .Select(b => new
                {
                    b.ID,
                    b.TenBan,
                    b.SoChoNgoi,
                    TrangThai = b.TrangThai ? "Hoạt động" : "Ngưng"
                })
                .ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Ban b = new Ban()
            {
                TenBan = txtTenBan.Text,
                SoChoNgoi = (int)numSoChoNgoi.Value,
                TrangThai = chkHoatDong.Checked
            };

            context.Ban.Add(b);
            context.SaveChanges();

            LoadBan();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            idDangChon = (int)dgvBan.CurrentRow.Cells["ID"].Value;

            txtTenBan.Text = dgvBan.CurrentRow.Cells["TenBan"].Value.ToString();
            numSoChoNgoi.Value = Convert.ToInt32(dgvBan.CurrentRow.Cells["SoChoNgoi"].Value);

            chkHoatDong.Checked = dgvBan.CurrentRow.Cells["TrangThai"].Value.ToString() == "Hoạt động";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (idDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            var ban = context.Ban.Find(idDangChon);

            if (ban != null)
            {
                context.Ban.Remove(ban);
                context.SaveChanges();
                LoadBan();

                MessageBox.Show("Xóa thành công!");
            }
        }

        private void frmdatban_Load(object sender, EventArgs e)
        {
            LoadBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            var ban = context.Ban.Find(idDangChon);

            if (ban != null)
            {
                ban.TenBan = txtTenBan.Text;
                ban.SoChoNgoi = (int)numSoChoNgoi.Value;
                ban.TrangThai = chkHoatDong.Checked;

                context.SaveChanges();
                LoadBan();

                MessageBox.Show("Cập nhật thành công!");
            }
        }
    }
}
