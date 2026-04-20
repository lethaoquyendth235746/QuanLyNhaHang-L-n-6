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
    public partial class frmthemnhanvien : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();

        public frmthemnhanvien()
        {
            InitializeComponent();
        }

        private void frmthemnhanvien_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMK.UseSystemPasswordChar = true;

            // ⭐ THÊM DỮ LIỆU MẪU NẾU CHƯA CÓ
            if (!context.VaiTro.Any())
            {
                context.VaiTro.Add(new VaiTro { TenVaiTro = "Admin", MoTa = "" });
                context.VaiTro.Add(new VaiTro { TenVaiTro = "Quản lý", MoTa = "" });
                context.VaiTro.Add(new VaiTro { TenVaiTro = "Thu ngân", MoTa = "" });
                context.VaiTro.Add(new VaiTro { TenVaiTro = "Phục vụ", MoTa = "" });

                context.SaveChanges();
            }

            // LOAD LẠI
            var vaiTro = context.VaiTro.ToList();

            cboVaiTro.DataSource = vaiTro;
            cboVaiTro.DisplayMember = "TenVaiTro";
            cboVaiTro.ValueMember = "ID";
            cboVaiTro.SelectedIndex = -1;
            cboVaiTro.Text = "-- Chọn vai trò --";

            txtTaiKhoan.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ===== VALIDATE =====
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            if (txtMatKhau.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            if (cboVaiTro.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!");
                return;
            }

            // ===== CHECK TRÙNG =====
            var check = context.NhanVien
                .FirstOrDefault(x => x.TenDangNhap.ToLower()
                    == txtTaiKhoan.Text.Trim().ToLower());

            if (check != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại!");
                return;
            }

            try
            {
                NhanVien nv = new NhanVien
                {
                    HoVaTen = txtHoTen.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = "", // ⭐ THÊM DÒNG NÀY
                    TenDangNhap = txtTaiKhoan.Text.Trim(),

                    // ⭐ MÃ HÓA PASSWORD
                    MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text.Trim()),

                    VaiTroID = Convert.ToInt32(cboVaiTro.SelectedValue),
                    TrangThai = true
                };

                context.NhanVien.Add(nv);
                context.SaveChanges();

                MessageBox.Show("Thêm nhân viên thành công!");

                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.InnerException?.Message ?? ex.ToString());
            }
        }
        private void LamMoiForm()
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtXacNhanMK.Clear();

            cboVaiTro.SelectedIndex = -1;
            cboVaiTro.Text = "-- Chọn vai trò --";
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMK.Checked;
            txtXacNhanMK.UseSystemPasswordChar = !chkHienMK.Checked;
        }
    }
}
