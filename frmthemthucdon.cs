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

    public partial class frmthemthucdon : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        List<MonAn> dsMonChon = new List<MonAn>();
        int? thucDonID = null;

        public frmthemthucdon(int id)
        {
            InitializeComponent();
            thucDonID = id;
        }
        public frmthemthucdon()
        {
            InitializeComponent();
           
        }

        private void btnThemMatHang_Click(object sender, EventArgs e)
        {
            frmChonMon f = new frmChonMon();

            if (f.ShowDialog() == DialogResult.OK)
            {
                foreach (var mon in f.MonDuocChon)
                {
                    if (!dsMonChon.Any(x => x.ID == mon.ID))
                    {
                        dsMonChon.Add(mon);

                        dgvMon.Rows.Add(
                            mon.ID,
                            mon.TenMon,
                            mon.GiaMonAns.FirstOrDefault()?.GiaBan ?? 0,
                            mon.DanhMuc?.TenDanhMuc
                        );
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int thutu;
            if (!int.TryParse(txtThuTu.Text, out thutu))
            {
                MessageBox.Show("Thứ tự không hợp lệ!");
                return;
            }

            if (thucDonID == null)
            {
                // 👉 THÊM
                ThucDon td = new ThucDon
                {
                    TenThucDon = txtTenThucDon.Text,
                    ThuTu = thutu
                };

                context.ThucDon.Add(td);
                context.SaveChanges();

                foreach (var mon in dsMonChon)
                {
                    context.ChiTietThucDon.Add(new ChiTietThucDon
                    {
                        ThucDonID = td.ID,
                        MonAnID = mon.ID
                    });
                }
            }
            else
            {
                // 👉 SỬA
                var td = context.ThucDon
                    .Include(x => x.ChiTietThucDons)
                    .FirstOrDefault(x => x.ID == thucDonID);

                td.TenThucDon = txtTenThucDon.Text;
                td.ThuTu = thutu;

                // xóa món cũ
                context.ChiTietThucDon.RemoveRange(td.ChiTietThucDons);

                // thêm lại
                foreach (var mon in dsMonChon)
                {
                    context.ChiTietThucDon.Add(new ChiTietThucDon
                    {
                        ThucDonID = td.ID,
                        MonAnID = mon.ID
                    });
                }
            }

            context.SaveChanges();
            MessageBox.Show("Lưu thành công!");
            this.Close();

        }

        private void frmthemthucdon_Load(object sender, EventArgs e)
        {
            dgvMon.Columns.Clear();

            dgvMon.Columns.Add("ID", "ID");
            dgvMon.Columns.Add("TenMon", "Tên món");
            dgvMon.Columns.Add("GiaBan", "Giá bán");
            dgvMon.Columns.Add("DanhMuc", "Danh mục");

            dgvMon.Columns["ID"].Visible = false;

            // 🔥 LOAD KHI SỬA
            if (thucDonID != null)
            {
                var td = context.ThucDon
                    .Include(x => x.ChiTietThucDons)
                        .ThenInclude(x => x.MonAn)
                            .ThenInclude(m => m.DanhMuc)
                    .Include(x => x.ChiTietThucDons)
                        .ThenInclude(x => x.MonAn.GiaMonAns)
                    .FirstOrDefault(x => x.ID == thucDonID);

                if (td != null)
                {
                    txtTenThucDon.Text = td.TenThucDon;
                    txtThuTu.Text = td.ThuTu.ToString();

                    foreach (var ct in td.ChiTietThucDons)
                    {
                        dgvMon.Rows.Add(
                            ct.MonAn.ID,
                            ct.MonAn.TenMon,
                            ct.MonAn.GiaMonAns.FirstOrDefault()?.GiaBan ?? 0,
                            ct.MonAn.DanhMuc?.TenDanhMuc
                        );

                        dsMonChon.Add(ct.MonAn);
                    }
                }
            }
        }
    }
}
