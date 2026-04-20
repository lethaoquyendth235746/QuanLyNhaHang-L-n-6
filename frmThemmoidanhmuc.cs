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
    public partial class frmThemmoidanhmuc : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        public frmThemmoidanhmuc()
        {
            InitializeComponent();
        }

        private void frmThemmoidanhmuc_Load(object sender, EventArgs e)
        {

        }


        private void btnTrolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!");
                return;
            }

            try
            {
                DanhMuc dm = new DanhMuc();
                dm.TenDanhMuc = txtTenDanhMuc.Text;
                dm.MoTa = txtMoTa.Text;
                dm.TrangThai = true;

                context.DanhMuc.Add(dm); // chú ý chữ S
                context.SaveChanges();

                MessageBox.Show("Thêm danh mục thành công!");

                txtTenDanhMuc.Clear();
                txtMoTa.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }



}
