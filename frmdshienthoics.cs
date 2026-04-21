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
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmdshienthoics : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();

        public frmdshienthoics()
        {
            InitializeComponent();
        }

        private void frmdshienthoics_Load(object sender, EventArgs e)
        {
            TaoCotDataGridView();
            LoadDanhSachMatHang();
            DinhDangDataGridView();
            dgvMatHang.CellDoubleClick += dgvMatHang_CellDoubleClick;
            
        }
        private void TaoCotDataGridView()
        {
            dgvMatHang.Columns.Clear();
            dgvMatHang.AutoGenerateColumns = false;
            dgvMatHang.AllowUserToAddRows = false;

            // Checkbox đầu dòng
            DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
            colCheck.Name = "Chon";
            colCheck.HeaderText = "";
            colCheck.Width = 40;
            dgvMatHang.Columns.Add(colCheck);

            // ID ẩn
            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID";
            colID.HeaderText = "ID";
            colID.Visible = false;
            dgvMatHang.Columns.Add(colID);

            // Cột ảnh
            DataGridViewImageColumn colHinh = new DataGridViewImageColumn();
            colHinh.Name = "HinhAnh";
            colHinh.HeaderText = "";
            colHinh.Width = 60;
            colHinh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvMatHang.Columns.Add(colHinh);

            // Mặt hàng
            DataGridViewTextBoxColumn colTenMon = new DataGridViewTextBoxColumn();
            colTenMon.Name = "TenMon";
            colTenMon.HeaderText = "Mặt hàng";
            colTenMon.Width = 250;
            dgvMatHang.Columns.Add(colTenMon);

            // Danh mục
            DataGridViewTextBoxColumn colDanhMuc = new DataGridViewTextBoxColumn();
            colDanhMuc.Name = "TenDanhMuc";
            colDanhMuc.HeaderText = "Danh mục";
            colDanhMuc.Width = 120;
            dgvMatHang.Columns.Add(colDanhMuc);

            // Giá thành
            DataGridViewTextBoxColumn colGiaBan = new DataGridViewTextBoxColumn();
            colGiaBan.Name = "GiaBan";
            colGiaBan.HeaderText = "Giá thành";
            colGiaBan.Width = 120;
            dgvMatHang.Columns.Add(colGiaBan);

            // Đơn vị tính
            DataGridViewTextBoxColumn colDonViTinh = new DataGridViewTextBoxColumn();
            colDonViTinh.Name = "DonViTinh";
            colDonViTinh.HeaderText = "Đơn vị tính";
            colDonViTinh.Width = 100;
            dgvMatHang.Columns.Add(colDonViTinh);

            // Ghi chú
            DataGridViewTextBoxColumn colMoTa = new DataGridViewTextBoxColumn();
            colMoTa.Name = "MoTa";
            colMoTa.HeaderText = "Ghi chú";
            colMoTa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMatHang.Columns.Add(colMoTa);

            dgvMatHang.RowTemplate.Height = 55;
        }
        // 2. LOAD DỮ LIỆU
        // ==========================
        private void LoadDanhSachMatHang()
        {
            dgvMatHang.Rows.Clear();

            var ds = context.MonAn
                .Include(x => x.DanhMuc)
                .Include(x => x.GiaMonAns)
                .Select(x => new
                {
                    x.ID,
                    x.TenMon,
                    x.HinhAnh,
                    TenDanhMuc = x.DanhMuc != null ? x.DanhMuc.TenDanhMuc : "",
                    GiaBan = x.GiaMonAns.OrderBy(g => g.ID).Select(g => g.GiaBan).FirstOrDefault(),
                    x.DonViTinh,
                    MoTa = x.MoTa
                })
                .ToList();

            foreach (var item in ds)
            {
                Image img = null;

                try
                {
                    if (!string.IsNullOrEmpty(item.HinhAnh) && File.Exists(item.HinhAnh))
                    {
                        // Đọc ảnh an toàn tránh lỗi lock file
                        using (FileStream fs = new FileStream(item.HinhAnh, FileMode.Open, FileAccess.Read))
                        {
                            img = Image.FromStream(fs);
                            img = new Bitmap(img);
                        }
                    }
                }
                catch
                {
                    img = null;
                }

                dgvMatHang.Rows.Add(
                    false,              // checkbox
                    item.ID,
                    img,
                    item.TenMon,
                    item.TenDanhMuc,
                    item.GiaBan.ToString("N0") + " đ",
                    item.DonViTinh,
                    item.MoTa
                );
            }
        }
        // 3. ĐỊNH DẠNG GIAO DIỆN BẢNG
        private void DinhDangDataGridView()
        {
            dgvMatHang.BorderStyle = BorderStyle.None;
            dgvMatHang.BackgroundColor = Color.White;
            dgvMatHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMatHang.GridColor = Color.Gainsboro;

            dgvMatHang.EnableHeadersVisualStyles = false;
            dgvMatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMatHang.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvMatHang.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvMatHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvMatHang.ColumnHeadersHeight = 40;

            dgvMatHang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvMatHang.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            dgvMatHang.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMatHang.DefaultCellStyle.BackColor = Color.White;
            dgvMatHang.DefaultCellStyle.ForeColor = Color.Black;

            dgvMatHang.RowHeadersVisible = false;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.MultiSelect = false;
            dgvMatHang.ReadOnly = false;

            dgvMatHang.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMatHang.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248);
        }
        //4. TÌM KIẾM MẶT HÀNG

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text.Trim().ToLower();
            dgvMatHang.Rows.Clear();

            var ds = context.MonAn
                .Include(x => x.DanhMuc)
                .Include(x => x.GiaMonAns)
                .Where(x => x.TenMon.ToLower().Contains(tukhoa)
                         || x.DanhMuc.TenDanhMuc.ToLower().Contains(tukhoa))
                .Select(x => new
                {
                    x.ID,
                    x.TenMon,
                    x.HinhAnh,
                    TenDanhMuc = x.DanhMuc != null ? x.DanhMuc.TenDanhMuc : "",
                    GiaBan = x.GiaMonAns.OrderBy(g => g.ID).Select(g => g.GiaBan).FirstOrDefault(),
                    x.DonViTinh,
                    MoTa = x.MoTa
                })
                .ToList();

            foreach (var item in ds)
            {
                Image img = null;

                try
                {
                    if (!string.IsNullOrEmpty(item.HinhAnh) && File.Exists(item.HinhAnh))
                    {
                        using (FileStream fs = new FileStream(item.HinhAnh, FileMode.Open, FileAccess.Read))
                        {
                            img = Image.FromStream(fs);
                            img = new Bitmap(img);
                        }
                    }
                }
                catch
                {
                    img = null;
                }

                dgvMatHang.Rows.Add(
                    false,
                    item.ID,
                    img,
                    item.TenMon,
                    item.TenDanhMuc,
                    item.GiaBan.ToString("N0") + " đ",
                    item.DonViTinh,
                    item.MoTa
                );
            }

        }
        //4. NÚT THÊM MẶT HÀNG

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            frmthemmathang f = new frmthemmathang();

            f.MdiParent = this.MdiParent; // QUAN TRỌNG
            f.WindowState = FormWindowState.Maximized;

            f.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dgvMatHang.CurrentRow.Cells["ID"].Value);

            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.No) return;

            try
            {
                var mon = context.MonAn
                    .Include(x => x.GiaMonAns)
                    .FirstOrDefault(x => x.ID == id);

                if (mon != null)
                {
                    // Xóa giá trước
                    if (mon.GiaMonAns != null && mon.GiaMonAns.Any())
                    {
                        context.GiaMonAn.RemoveRange(mon.GiaMonAns);
                    }

                    context.MonAn.Remove(mon);
                    context.SaveChanges();

                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachMatHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        

        private void dgvMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không cho bấm header hoặc dòng rỗng
            if (e.RowIndex < 0 || e.RowIndex >= dgvMatHang.Rows.Count)
                return;

            // Kiểm tra ô ID có tồn tại không
            if (dgvMatHang.Rows[e.RowIndex].Cells["ID"].Value == null)
                return;

            int idMonAn = Convert.ToInt32(dgvMatHang.Rows[e.RowIndex].Cells["ID"].Value);

            frmchinhs parentForm = this.Owner as frmchinhs;

            if (parentForm != null)
            {
                frmthongtinmathang f = new frmthongtinmathang(idMonAn);
                f.Owner = parentForm;
                

            }

        }
    }

}

