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
    public partial class frmdanhmuc : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        public frmdanhmuc()
        {
            InitializeComponent();
        }


        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            //frmchinhs parentForm = this.Owner as frmchinhs;

            //if (parentForm != null)
           // {
                frmThemmoidanhmuc f = new frmThemmoidanhmuc();
            // f.Owner = parentForm; // giữ chuỗi điều hướng
            // parentForm.OpenChildForm(f);
            f.Show();
           // }
        }

        private void frmdanhmuc_Load(object sender, EventArgs e)
        {
            TaoCotDataGridView();
            LoadDanhSachDanhMuc();
            DinhDangDataGridView();
        }
        //1. TẠO CỘT DATAGRIDVIEW
        private void TaoCotDataGridView()
        {
            dgvDanhMuc.Columns.Clear();
            dgvDanhMuc.AutoGenerateColumns = false;
            dgvDanhMuc.AllowUserToAddRows = false;

            // Checkbox
            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "Chon";
            colCheck.HeaderText = "";
            colCheck.Width = 40;
            dgvDanhMuc.Columns.Add(colCheck);

            // ID ẩn
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID";
            colID.HeaderText = "ID";
            colID.Visible = false;
            dgvDanhMuc.Columns.Add(colID);

            // STT
            DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            colSTT.Name = "STT";
            colSTT.HeaderText = "STT";
            colSTT.Width = 60;
            dgvDanhMuc.Columns.Add(colSTT);

            // Tên danh mục
            DataGridViewTextBoxColumn colTenDanhMuc = new DataGridViewTextBoxColumn();
            colTenDanhMuc.Name = "TenDanhMuc";
            colTenDanhMuc.HeaderText = "Tên danh mục";
            colTenDanhMuc.Width = 250;
            dgvDanhMuc.Columns.Add(colTenDanhMuc);

            // Số lượng mặt hàng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.Name = "SoLuongMatHang";
            colSoLuong.HeaderText = "Số lượng mặt hàng";
            colSoLuong.Width = 150;
            dgvDanhMuc.Columns.Add(colSoLuong);

            // Mô tả
            DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn();
            colMoTa.Name = "MoTa";
            colMoTa.HeaderText = "Mô tả";
            colMoTa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDanhMuc.Columns.Add(colMoTa);

            // Nút Xem
            DataGridViewButtonColumn colXem = new DataGridViewButtonColumn();
            colXem.Name = "Xem";
            colXem.HeaderText = "Xem";
            colXem.Text = "Xem";
            colXem.UseColumnTextForButtonValue = true;
            colXem.Width = 80;
            dgvDanhMuc.Columns.Add(colXem);

            dgvDanhMuc.RowTemplate.Height = 45;
        }
        //2.  2. LOAD DANH SÁCH DANH MỤC
        private void LoadDanhSachDanhMuc()
        {
            dgvDanhMuc.Rows.Clear();

            var ds = context.DanhMuc
                .Include(x => x.MonAns)
                .Where(x => x.TrangThai == true)
                .Select(x => new
                {
                    x.ID,
                    x.TenDanhMuc,
                    x.MoTa,
                    SoLuongMatHang = x.MonAns.Count()
                })
                .ToList();

            int stt = 1;
            foreach (var item in ds)
            {
                dgvDanhMuc.Rows.Add(
                    false,                  // checkbox
                    item.ID,                // ID
                    stt++,                  // STT
                    item.TenDanhMuc,        // Tên danh mục
                    item.SoLuongMatHang,    // Số lượng mặt hàng
                    item.MoTa,              // Mô tả
                    "Xem"                   // Nút xem
                );
            }
        }
        //3. ĐỊNH DẠNG Giao Diện
        private void DinhDangDataGridView()
        {
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhMuc.GridColor = Color.Gainsboro;

            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDanhMuc.ColumnHeadersHeight = 40;

            dgvDanhMuc.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvDanhMuc.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgvDanhMuc.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDanhMuc.DefaultCellStyle.BackColor = Color.White;
            dgvDanhMuc.DefaultCellStyle.ForeColor = Color.Black;

            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.MultiSelect = false;
            dgvDanhMuc.ReadOnly = false;

            dgvDanhMuc.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);

            dgvDanhMuc.Columns["Chon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        //4. TÌM KIẾM
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim().ToLower();
            dgvDanhMuc.Rows.Clear();

            var ds = context.DanhMuc
                .Include(x => x.MonAns)
                .Where(x => x.TrangThai == true &&
                            x.TenDanhMuc.ToLower().Contains(tukhoa))
                .Select(x => new
                {
                    x.ID,
                    x.TenDanhMuc,
                    x.MoTa,
                    SoLuongMatHang = x.MonAns.Count()
                })
                .ToList();

            int stt = 1;
            foreach (var item in ds)
            {
                dgvDanhMuc.Rows.Add(
                    false,
                    item.ID,
                    stt++,
                    item.TenDanhMuc,
                    item.SoLuongMatHang,
                    item.MoTa,
                    "Xem"
                );
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa các danh mục đã chọn không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No) return;

            try
            {
                bool coXoa = false;

                foreach (DataGridViewRow row in dgvDanhMuc.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["Chon"].Value);

                    if (isChecked)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value);

                        var danhMuc = context.DanhMuc
                            .Include(x => x.MonAns)
                            .FirstOrDefault(x => x.ID == id);

                        if (danhMuc != null)
                        {
                            // Nếu còn món ăn thì không cho xóa
                            if (danhMuc.MonAns != null && danhMuc.MonAns.Any())
                            {
                                MessageBox.Show("Danh mục '" + danhMuc.TenDanhMuc + "' vẫn còn mặt hàng, không thể xóa!");
                                continue;
                            }

                            context.DanhMuc.Remove(danhMuc);
                            coXoa = true;
                        }
                    }
                }

                if (coXoa)
                {
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachDanhMuc();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn danh mục cần xóa!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhMuc.Columns[e.ColumnIndex].Name == "Xem")
            {
                int idDanhMuc = Convert.ToInt32(dgvDanhMuc.Rows[e.RowIndex].Cells["ID"].Value);
                string tenDanhMuc = dgvDanhMuc.Rows[e.RowIndex].Cells["TenDanhMuc"].Value.ToString();

              //  frmthongtinmathang f = new frmthongtinmathang(idDanhMuc, tenDanhMuc);
                //f.ShowDialog();
            }
        }
        // click nút xem

    }
}
