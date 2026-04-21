namespace QuanLyNhaHang
{
    partial class frmchinhs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            đăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            đổiMặtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnKhachHang = new ToolStripMenuItem();
            mnnhanvien = new ToolStripMenuItem();
            mặtHàngToolStripMenuItem = new ToolStripMenuItem();
            mnudanhsachmathang = new ToolStripMenuItem();
            mndanhmuc = new ToolStripMenuItem();
            mnthucdon = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            mnban = new ToolStripMenuItem();
            nmDatBan = new ToolStripMenuItem();
            thốngKêBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            thốngKêSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhânMềmToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, thốngKêBáoCáoToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1147, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngNhậpToolStripMenuItem, đăngXuấtToolStripMenuItem, đổiMặtKhẩuToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            đăngNhậpToolStripMenuItem.Size = new Size(181, 26);
            đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(181, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMặtKhẩuToolStripMenuItem
            // 
            đổiMặtKhẩuToolStripMenuItem.Name = "đổiMặtKhẩuToolStripMenuItem";
            đổiMặtKhẩuToolStripMenuItem.Size = new Size(181, 26);
            đổiMặtKhẩuToolStripMenuItem.Text = "Đổi mặt khẩu";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnKhachHang, mnnhanvien, mặtHàngToolStripMenuItem, mnthucdon, hóaĐơnToolStripMenuItem, mnban, nmDatBan });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnKhachHang
            // 
            mnKhachHang.Name = "mnKhachHang";
            mnKhachHang.Size = new Size(224, 26);
            mnKhachHang.Text = "Khách hàng";
            mnKhachHang.Click += mnKhachHang_Click;
            // 
            // mnnhanvien
            // 
            mnnhanvien.Name = "mnnhanvien";
            mnnhanvien.Size = new Size(224, 26);
            mnnhanvien.Text = "Nhân viên";
            mnnhanvien.Click += mnnhanvien_Click;
            // 
            // mặtHàngToolStripMenuItem
            // 
            mặtHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnudanhsachmathang, mndanhmuc });
            mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
            mặtHàngToolStripMenuItem.Size = new Size(224, 26);
            mặtHàngToolStripMenuItem.Text = "Mặt hàng";
            // 
            // mnudanhsachmathang
            // 
            mnudanhsachmathang.Name = "mnudanhsachmathang";
            mnudanhsachmathang.Size = new Size(227, 26);
            mnudanhsachmathang.Text = "Danh sách mặt hàng";
            mnudanhsachmathang.Click += mnudanhsachmathang_Click;
            // 
            // mndanhmuc
            // 
            mndanhmuc.Name = "mndanhmuc";
            mndanhmuc.Size = new Size(227, 26);
            mndanhmuc.Text = "Danh mục";
            mndanhmuc.Click += mndanhmuc_Click;
            // 
            // mnthucdon
            // 
            mnthucdon.Name = "mnthucdon";
            mnthucdon.Size = new Size(224, 26);
            mnthucdon.Text = "Thực đơn";
            mnthucdon.Click += mnthucdon_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn ";
            // 
            // mnban
            // 
            mnban.Name = "mnban";
            mnban.Size = new Size(224, 26);
            mnban.Text = "Thêm bàn";
            mnban.Click += mnban_Click;
            // 
            // nmDatBan
            // 
            nmDatBan.Name = "nmDatBan";
            nmDatBan.Size = new Size(224, 26);
            nmDatBan.Text = "Order món";
            nmDatBan.Click += nmDatBan_Click;
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêSảnPhẩmToolStripMenuItem, thốngKêDoanhThuToolStripMenuItem });
            thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            thốngKêBáoCáoToolStripMenuItem.Size = new Size(152, 24);
            thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê _ Báo cáo";
            // 
            // thốngKêSảnPhẩmToolStripMenuItem
            // 
            thốngKêSảnPhẩmToolStripMenuItem.Name = "thốngKêSảnPhẩmToolStripMenuItem";
            thốngKêSảnPhẩmToolStripMenuItem.Size = new Size(224, 26);
            thốngKêSảnPhẩmToolStripMenuItem.Text = "Thống kê sản phẩm";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            thốngKêDoanhThuToolStripMenuItem.Size = new Size(224, 26);
            thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hướngDẫnSửDụngToolStripMenuItem, thôngTinPhânMềmToolStripMenuItem });
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(78, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(230, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // thôngTinPhânMềmToolStripMenuItem
            // 
            thôngTinPhânMềmToolStripMenuItem.Name = "thôngTinPhânMềmToolStripMenuItem";
            thôngTinPhânMềmToolStripMenuItem.Size = new Size(230, 26);
            thôngTinPhânMềmToolStripMenuItem.Text = "Thông tin phân mềm";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 593);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1147, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(118, 20);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1014, 20);
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // frmchinhs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 619);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmchinhs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý bán hàng";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem đổiMặtKhẩuToolStripMenuItem;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem mnKhachHang;
        private ToolStripMenuItem mnnhanvien;
        private ToolStripMenuItem mặtHàngToolStripMenuItem;
        private ToolStripMenuItem mnudanhsachmathang;
        private ToolStripMenuItem mndanhmuc;
        private ToolStripMenuItem mnthucdon;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ToolStripMenuItem thốngKêSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhânMềmToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem mnban;
        private ToolStripMenuItem nmDatBan;
    }
}