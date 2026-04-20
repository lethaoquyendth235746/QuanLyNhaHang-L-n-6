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
    public partial class frmChonMon : Form
    {
        QLNhaHangDbContext context = new QLNhaHangDbContext();

        // danh sách món được chọn
        public List<MonAn> MonDuocChon = new List<MonAn>();
        public frmChonMon()
        {
            InitializeComponent();
        }

        private void frmChonMon_Load(object sender, EventArgs e)
        {
            dgvMon.Columns.Clear();

            dgvMon.Columns.Add(new DataGridViewCheckBoxColumn() { Width = 40 });
            dgvMon.Columns.Add("ID", "ID");
            dgvMon.Columns.Add("TenMon", "Tên món");
            dgvMon.Columns.Add("GiaBan", "Giá bán");
            dgvMon.Columns.Add("DanhMuc", "Danh mục");

            dgvMon.Columns["ID"].Visible = false;

            // 🔥 QUAN TRỌNG
            dgvMon.ReadOnly = false;
            dgvMon.Columns[0].ReadOnly = false;
            dgvMon.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvMon.CurrentCellDirtyStateChanged += dgvMon_CurrentCellDirtyStateChanged;

            var ds = context.MonAn
                .Include(x => x.DanhMuc)
                .Include(x => x.GiaMonAns)
                .Where(x => x.TrangThai == true)
                .ToList();

            foreach (var item in ds)
            {
                dgvMon.Rows.Add(
                    false,
                    item.ID,
                    item.TenMon,
                    item.GiaMonAns.FirstOrDefault()?.GiaBan ?? 0,
                    item.DanhMuc?.TenDanhMuc
                );
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            dgvMon.EndEdit(); // 🔥 QUAN TRỌNG

            foreach (DataGridViewRow row in dgvMon.Rows)
            {
                bool isChecked = row.Cells[0].Value != null && (bool)row.Cells[0].Value;

                if (isChecked)
                {
                    int id = Convert.ToInt32(row.Cells[1].Value);

                    var mon = context.MonAn
                        .Include(x => x.DanhMuc)
                        .Include(x => x.GiaMonAns)
                        .FirstOrDefault(x => x.ID == id);

                    MonDuocChon.Add(mon);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvMon_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvMon.IsCurrentCellDirty)
            {
                dgvMon.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
    }
}
