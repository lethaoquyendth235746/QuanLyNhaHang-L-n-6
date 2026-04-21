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
    public partial class frmbanhang : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();
        int donHangID = -1;
        int banDangChon = -1;
        public frmbanhang()
        {
            InitializeComponent();
        }
        private void LoadBan()
        {
            flpBan.Controls.Clear();

            var dsBan = context.Ban
                .Where(b => b.TrangThai == true)
                .ToList();

            foreach (var b in dsBan)
            {
                Button btn = new Button();

                btn.Width = 120;
                btn.Height = 80;

                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                bool dangDung = context.DonHang
                    .Any(d => d.BanID == b.ID && d.TrangThaiThanhToan == false);

                // 🔥 ƯU TIÊN: bàn đang chọn
                if (b.ID == banDangChon)
                {
                    btn.BackColor = Color.DeepSkyBlue;
                    btn.Text = b.TenBan + "\nĐang chọn";
                }
                else if (dangDung)
                {
                    btn.BackColor = Color.Red;
                    btn.Text = b.TenBan + "\nĐang dùng";
                }
                else
                {
                    btn.BackColor = Color.LightGreen;
                    btn.Text = b.TenBan + "\nTrống";
                }

                btn.Click += (s, e) =>
                {
                    XuLyBan(b.ID);
                };

                flpBan.Controls.Add(btn);
            }
        }

        private void ban_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadDanhMuc();
            TaoCot();
        }
        private void XuLyBan(int banID)
        {
            var don = context.DonHang
                .FirstOrDefault(d => d.BanID == banID && d.TrangThaiThanhToan == false);

            if (don == null)
            {
                DonHang dh = new DonHang()
                {
                    BanID = banID,
                    NgayLap = DateTime.Now,
                    TrangThaiThanhToan = false,
                    TongTien = 0,
                    NhanVienID = 1006 // sửa đúng ID
                };

                context.DonHang.Add(dh);
                context.SaveChanges();

                don = dh;
            }
            // 🔥 THÊM DÒNG NÀY
            banDangChon = banID;

            donHangID = don.ID;

            LoadChiTiet();

            // 🔥 QUAN TRỌNG
            donHangID = don.ID;

            // 👉 load dữ liệu bên phải
            LoadChiTiet();
            LoadBan();
        }
        private void LoadDanhMuc()
        {
            cboDanhMuc.DataSource = context.DanhMuc
                .Where(x => x.TrangThai)
                .ToList();

            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "ID";
        }
        private void LoadMon(int danhMucID)
        {
            cboMon.DataSource = context.MonAn
                .Where(x => x.DanhMucID == danhMucID && x.TrangThai)
                .ToList();

            cboMon.DisplayMember = "TenMon";
            cboMon.ValueMember = "ID";
        }

        private void cboDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedValue == null) return;

            // 🔥 tránh lỗi DataRowView
            if (cboDanhMuc.SelectedValue is int)
            {
                int id = (int)cboDanhMuc.SelectedValue;
                LoadMon(id);
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (donHangID == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn!");
                return;
            }

            int monID = Convert.ToInt32(cboMon.SelectedValue);
            int soLuong = (int)numSoLuong.Value;

            var mon = context.MonAn
                .Where(x => x.ID == monID)
                .Select(x => new
                {
                    x.ID,
                    x.TenMon,
                    Gia = x.GiaMonAns.Select(g => g.GiaBan).FirstOrDefault()
                })
                .FirstOrDefault();

            var ct = context.ChiTietDonHang
                .FirstOrDefault(x => x.DonHangID == donHangID && x.MonAnID == monID);

            if (ct != null)
            {
                ct.SoLuong += soLuong;
                ct.ThanhTien = ct.SoLuong * ct.DonGia;
            }
            else
            {
                context.ChiTietDonHang.Add(new ChiTietDonHang
                {
                    DonHangID = donHangID,
                    MonAnID = monID,
                    SoLuong = soLuong,
                    DonGia = mon.Gia,
                    ThanhTien = mon.Gia * soLuong
                });
            }

            context.SaveChanges();

            LoadChiTiet();
        }
        private void TaoCot()
        {
            dvgChiTiet.Columns.Clear();

            dvgChiTiet.Columns.Add("TenMon", "Tên món");
            dvgChiTiet.Columns.Add("SoLuong", "SL");
            dvgChiTiet.Columns.Add("DonGia", "Đơn giá");
            dvgChiTiet.Columns.Add("ThanhTien", "Thành tiền");
        }
        private void LoadChiTiet()
        {
            dvgChiTiet.Rows.Clear();

            var ds = context.ChiTietDonHang
                .Where(x => x.DonHangID == donHangID)
                .Select(x => new
                {
                    TenMon = x.MonAn.TenMon,
                    x.SoLuong,
                    x.DonGia,
                    x.ThanhTien
                })
                .ToList();

            decimal tong = 0;

            foreach (var item in ds)
            {
                dvgChiTiet.Rows.Add(
                    item.TenMon,
                    item.SoLuong,
                    item.DonGia,
                    item.ThanhTien
                );

                tong += item.ThanhTien;
            }

            txtTongTien.Text = tong.ToString("N0");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            var don = context.DonHang.Find(donHangID);

            if (don != null)
            {
                don.TongTien = context.ChiTietDonHang
                    .Where(x => x.DonHangID == donHangID)
                    .Sum(x => x.ThanhTien);

                don.TrangThaiThanhToan = true;

                context.SaveChanges();

                LoadChiTiet();
                LoadBan(); //
                MessageBox.Show("Thanh toán thành công!");

                donHangID = -1;
                banDangChon = -1;
                dvgChiTiet.Rows.Clear();
                txtTongTien.Clear();

                LoadBan();
            }
        }
    }
}
