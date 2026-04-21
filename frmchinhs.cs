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
    public partial class frmchinhs : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        frmdshienthoics dshienthoics = null;
        frmdanhmuc danhmuc = null;
        frmthucdon thucdon = null;
        frmdanhsachnhanvien danhsachnhanvien = null;
        frmdanhsachkhachhang danhsachkhachhang = null;
        frmbanhang Datban = null;
        frmban datban = null;
        public frmchinhs()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnudanhsachmathang_Click(object sender, EventArgs e)
        {
            if (dshienthoics == null || dshienthoics.IsDisposed)
            {
                dshienthoics = new frmdshienthoics();

                dshienthoics.MdiParent = this; // QUAN TRỌNG
                dshienthoics.WindowState = FormWindowState.Maximized; // full màn hình

                dshienthoics.Show();
            }
            else
            {
                dshienthoics.Activate();
            }
        }

        private void mndanhmuc_Click(object sender, EventArgs e)
        {
            if (danhmuc == null || danhmuc.IsDisposed)
            {
                danhmuc = new frmdanhmuc();

                danhmuc.MdiParent = this; // QUAN TRỌNG
                danhmuc.WindowState = FormWindowState.Maximized; // full màn hình

                danhmuc.Show();
            }
            else
            {
                danhmuc.Activate();
            }
        }

        private void mnthucdon_Click(object sender, EventArgs e)
        {
            if (thucdon == null || thucdon.IsDisposed)
            {
                thucdon = new frmthucdon();

                thucdon.MdiParent = this; // QUAN TRỌNG
                thucdon.WindowState = FormWindowState.Maximized; // full màn hình

                thucdon.Show();
            }
            else
            {
                thucdon.Activate();
            }

        }

        private void mnnhanvien_Click(object sender, EventArgs e)
        {
            if (danhsachnhanvien == null || danhsachnhanvien.IsDisposed)
            {
                danhsachnhanvien = new frmdanhsachnhanvien();

                danhsachnhanvien.MdiParent = this; // QUAN TRỌNG
                danhsachnhanvien.WindowState = FormWindowState.Maximized; // full màn hình

                danhsachnhanvien.Show();
            }
            else
            {
                danhsachnhanvien.Activate();
            }

        }

        private void mnKhachHang_Click(object sender, EventArgs e)
        {
            if (danhsachkhachhang == null || danhsachkhachhang.IsDisposed)
            {
                danhsachkhachhang = new frmdanhsachkhachhang();

                danhsachkhachhang.MdiParent = this; // QUAN TRỌNG
                danhsachkhachhang.WindowState = FormWindowState.Maximized; // full màn hình

                danhsachkhachhang.Show();
            }
            else
            {
                danhsachkhachhang.Activate();
            }
        }

        private void mnban_Click(object sender, EventArgs e)
        {
            if (datban == null || datban.IsDisposed)
            {
                datban = new frmban();

                datban.MdiParent = this; // QUAN TRỌNG
                datban.WindowState = FormWindowState.Maximized; // full màn hình

                datban.Show();
            }
            else
            {
                datban.Activate();
            }

        }

        private void nmDatBan_Click(object sender, EventArgs e)
        {
            if (Datban == null || Datban.IsDisposed)
            {
                Datban = new frmbanhang();

                Datban.MdiParent = this; // QUAN TRỌNG
                Datban.WindowState = FormWindowState.Maximized; // full màn hình

                Datban.Show();
            }
            else
            {
                Datban.Activate();
            }
        }
    }
}
