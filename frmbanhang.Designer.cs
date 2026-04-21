namespace QuanLyNhaHang
{
    partial class frmbanhang
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
            components = new System.ComponentModel.Container();
            flpBan = new FlowLayoutPanel();
            label1 = new Label();
            cboDanhMuc = new ComboBox();
            label2 = new Label();
            numSoLuong = new NumericUpDown();
            label3 = new Label();
            cboMon = new ComboBox();
            btnThemMon = new Button();
            dvgChiTiet = new DataGridView();
            label4 = new Label();
            txtTongTien = new TextBox();
            btnThanhToan = new Button();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgChiTiet).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.BackColor = Color.LightGray;
            flpBan.Location = new Point(29, 26);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(599, 667);
            flpBan.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 1;
            label1.Text = "Danh mục món ăn";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(27, 72);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(238, 28);
            cboDanhMuc.TabIndex = 2;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 120);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(27, 143);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(234, 27);
            numSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 50);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 1;
            label3.Text = "Danh mục món ăn";
            // 
            // cboMon
            // 
            cboMon.FormattingEnabled = true;
            cboMon.Location = new Point(396, 77);
            cboMon.Name = "cboMon";
            cboMon.Size = new Size(238, 28);
            cboMon.TabIndex = 2;
            // 
            // btnThemMon
            // 
            btnThemMon.BackColor = Color.Blue;
            btnThemMon.Location = new Point(396, 158);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(250, 29);
            btnThemMon.TabIndex = 4;
            btnThemMon.Text = "Thêm món";
            btnThemMon.UseVisualStyleBackColor = false;
            btnThemMon.Click += btnThemMon_Click;
            // 
            // dvgChiTiet
            // 
            dvgChiTiet.BackgroundColor = Color.White;
            dvgChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgChiTiet.Location = new Point(16, 43);
            dvgChiTiet.Name = "dvgChiTiet";
            dvgChiTiet.RowHeadersWidth = 51;
            dvgChiTiet.Size = new Size(991, 227);
            dvgChiTiet.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 502);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 1;
            label4.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(112, 495);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(207, 27);
            txtTongTien.TabIndex = 6;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Red;
            btnThanhToan.Location = new Point(769, 502);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(250, 29);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(numSoLuong);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(btnThemMon);
            groupBox2.Controls.Add(cboDanhMuc);
            groupBox2.Controls.Add(cboMon);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(681, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1041, 571);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin gọi món";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dvgChiTiet);
            groupBox3.Location = new Point(15, 202);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1014, 287);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "chi tiết hóa đơn";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flpBan);
            groupBox1.Location = new Point(4, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(656, 723);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách bàn ăn";
            // 
            // frmbanhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1704, 758);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmbanhang";
            Text = "ban";
            Load += ban_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgChiTiet).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpBan;
        private Label label1;
        private ComboBox cboDanhMuc;
        private Label label2;
        private NumericUpDown numSoLuong;
        private Label label3;
        private ComboBox cboMon;
        private Button btnThemMon;
        private DataGridView dvgChiTiet;
        private Label label4;
        private TextBox txtTongTien;
        private Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
    }
}