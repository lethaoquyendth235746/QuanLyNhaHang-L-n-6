using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyNhaHang.Data;

namespace QuanLyNhaHang
{
    public partial class frmthucdon : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        public frmthucdon()
        {
            InitializeComponent();
        }
        private void LoadThucDon()
        {
            dgvThucDon.Rows.Clear();

            var ds = context.ThucDon
                .OrderBy(x => x.ThuTu)
                .ToList();

            int stt = 1;
            foreach (var item in ds)
            {
                dgvThucDon.Rows.Add(
                    false,                 // ✅ checkbox
                    item.ID,
                    stt++,
                    item.TenThucDon,
                    item.ThuTu,
                    "Xem"
                );
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmthemthucdon f = new frmthemthucdon();
            f.ShowDialog();

            LoadThucDon();
        }

        private void frmthucdon_Load(object sender, EventArgs e)
        {
            TaoCot(); // nhớ tách hàm tạo cột
            LoadThucDon();
            // format thêm cho đẹp
            dgvThucDon.RowHeadersVisible = false;
            dgvThucDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucDon.AllowUserToAddRows = false;

        }
        private void TaoCot()
        {
            dgvThucDon.Columns.Clear();
            dgvThucDon.AutoGenerateColumns = false;

            // checkbox
            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "Chon";
            colCheck.Width = 40;
            dgvThucDon.Columns.Add(colCheck);

            // ID
            dgvThucDon.Columns.Add("ID", "ID");

            // STT
            dgvThucDon.Columns.Add("STT", "STT");

            // Tên thực đơn
            dgvThucDon.Columns.Add("TenThucDon", "Tên thực đơn");

            // Thứ tự
            dgvThucDon.Columns.Add("ThuTu", "Thứ tự");

            // nút xem
            DataGridViewButtonColumn colXem = new DataGridViewButtonColumn();
            colXem.Name = "Xem";
            colXem.Text = "Xem";
            colXem.UseColumnTextForButtonValue = true;
            dgvThucDon.Columns.Add(colXem);

            // ẩn ID
            dgvThucDon.Columns["ID"].Visible = false;

            // cho phép check
            dgvThucDon.ReadOnly = false;
            dgvThucDon.Columns["Chon"].ReadOnly = false;

            // fix checkbox không tick được
            dgvThucDon.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvThucDon.IsCurrentCellDirty)
                {
                    dgvThucDon.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };
        }

        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvThucDon.Columns[e.ColumnIndex].Name == "Xem")
            {
                int id = Convert.ToInt32(dgvThucDon.Rows[e.RowIndex].Cells["ID"].Value);

                frmthemthucdon f = new frmthemthucdon(id);
                f.ShowDialog();

                LoadThucDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No) return;

            bool coXoa = false;

            foreach (DataGridViewRow row in dgvThucDon.Rows)
            {
                bool check = row.Cells["Chon"].Value != null && (bool)row.Cells["Chon"].Value;

                if (check)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);

                    var td = context.ThucDon
                        .Include(x => x.ChiTietThucDons)
                        .FirstOrDefault(x => x.ID == id);

                    if (td != null)
                    {
                        context.ChiTietThucDon.RemoveRange(td.ChiTietThucDons);
                        context.ThucDon.Remove(td);
                        coXoa = true;
                    }
                }
            }

            if (coXoa)
            {
                context.SaveChanges();
                MessageBox.Show("Xóa thành công!");
                LoadThucDon();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn!");
            }
        }
    }
}
