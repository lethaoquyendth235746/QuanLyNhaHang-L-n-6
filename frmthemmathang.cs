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
    public partial class frmthemmathang : Form
    {
        string duongDanAnh = "";
        QLNhaHangDbContext context = new QLNhaHangDbContext();

        public frmthemmathang()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void frmthemmathang_Load(object sender, EventArgs e)
        {
            var danhMuc = context.DanhMuc
       .Where(x => x.TrangThai == true).ToList();

            cboDanhMuc.DataSource = danhMuc;
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.SelectedIndex = -1; // không chọn item nào
            cboDanhMuc.Text = "-- Chọn loại --"; // chữ hiện lên ban đầu

            // ⭐ Thêm đơn vị tính
            cboDonViTinh.Items.Add("-- Chọn đơn vị --");
            cboDonViTinh.Items.Add("Đĩa");
            cboDonViTinh.Items.Add("Kg");
            cboDonViTinh.Items.Add("Nồi");
            cboDonViTinh.Items.Add("Ly");
            cboDonViTinh.Items.Add("Con");

            cboDonViTinh.SelectedIndex = 0; // mặc định dòng đầu
            txtTenMatHang.Text = "VD: Cá hồi nướng muối ớt";
            txtTenMatHang.ForeColor = Color.Gray;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMatHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên món!");
                return;
            }

            if (txtTenMatHang.Text == "VD: Cá hồi nướng muối ớt")
            {
                MessageBox.Show("Vui lòng nhập tên món!");
                return;
            }

            if (cboDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục!");
                return;
            }

            if (cboDonViTinh.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!");
                return;
            }

            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan))
            {
                MessageBox.Show("Giá bán không hợp lệ!");
                return;
            }

            try
            {
                using (QLNhaHangDbContext context = new QLNhaHangDbContext())
                {
                    MonAn mon = new MonAn
                    {
                        TenMon = txtTenMatHang.Text.Trim(),
                        MoTa = txtGhiChu.Text.Trim(),
                        DonViTinh = cboDonViTinh.Text.Trim(),
                        TrangThai = true,
                        HinhAnh = duongDanAnh, // LƯU ĐƯỜNG DẪN ẢNH
                        DanhMucID = Convert.ToInt32(cboDanhMuc.SelectedValue)
                    };

                    context.MonAn.Add(mon);
                    context.SaveChanges();

                    GiaMonAn gia = new GiaMonAn
                    {
                        TenGia = "Mặc định",
                        GiaBan = giaBan,
                        GiaVon = 0,
                        MonAnID = mon.ID
                    };

                    context.GiaMonAn.Add(gia);
                    context.SaveChanges();
                }

                MessageBox.Show("Thêm mặt hàng thành công!");

                // KHÔNG tự quay lại nữa
                // Chỉ xóa form hoặc giữ nguyên theo ý bạn

                // Nếu muốn nhập tiếp món khác thì clear form:
                LamMoiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void LamMoiForm()
        {
            txtTenMatHang.Text = "VD: Cá hồi nướng muối ớt";
            txtTenMatHang.ForeColor = Color.Gray;

            txtGiaBan.Clear();
            txtGhiChu.Clear();

            cboDanhMuc.SelectedIndex = -1;
            cboDanhMuc.Text = "-- Chọn loại --";

            cboDonViTinh.SelectedIndex = 0;

            picHinh.Image = null;
            duongDanAnh = "";
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = ofd.FileName;

                picHinh.Image = Image.FromFile(duongDanAnh);
                picHinh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txtTenMatHang_Enter(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text == "VD: Cá hồi nướng muối ớt")
            {
                txtTenMatHang.Text = "";
                txtTenMatHang.ForeColor = Color.Black;
            }
        }

        private void txtTenMatHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMatHang.Text))
            {
                txtTenMatHang.Text = "VD: Cá hồi nướng muối ớt";
                txtTenMatHang.ForeColor = Color.Gray;
            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            frmThemmoidanhmuc f = new frmThemmoidanhmuc();
            f.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmchinhs parentForm = this.Owner as frmchinhs;

            if (parentForm != null)
            {
                frmdshienthoics frm = new frmdshienthoics();
                frm.Owner = parentForm;
                parentForm.OpenChildForm(frm);
            }
        }
    }
}