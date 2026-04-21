namespace QuanLyNhaHang
{
    partial class frmban
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
            dgvBan = new DataGridView();
            btnLuu = new FontAwesome.Sharp.IconButton();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            chkHoatDong = new CheckBox();
            numSoChoNgoi = new NumericUpDown();
            cbTrangThai = new ComboBox();
            txtTenBan = new TextBox();
            txtMaSo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoChoNgoi).BeginInit();
            SuspendLayout();
            // 
            // dgvBan
            // 
            dgvBan.AllowUserToAddRows = false;
            dgvBan.AllowUserToDeleteRows = false;
            dgvBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBan.BackgroundColor = Color.White;
            dgvBan.BorderStyle = BorderStyle.None;
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Location = new Point(458, 64);
            dgvBan.MultiSelect = false;
            dgvBan.Name = "dgvBan";
            dgvBan.ReadOnly = true;
            dgvBan.RowHeadersVisible = false;
            dgvBan.RowHeadersWidth = 51;
            dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBan.Size = new Size(885, 500);
            dgvBan.TabIndex = 36;
            dgvBan.CellClick += dgvBan_CellClick;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Navy;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnLuu.IconColor = Color.White;
            btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLuu.IconSize = 30;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(313, 552);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 44);
            btnLuu.TabIndex = 35;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnXoa.IconColor = Color.White;
            btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXoa.IconSize = 30;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(313, 475);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 44);
            btnXoa.TabIndex = 34;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.RoyalBlue;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnSua.IconColor = Color.White;
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 30;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(62, 552);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 44);
            btnSua.TabIndex = 32;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.RoyalBlue;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnThem.IconColor = Color.White;
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 30;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(62, 475);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 44);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkHoatDong);
            groupBox1.Controls.Add(numSoChoNgoi);
            groupBox1.Controls.Add(cbTrangThai);
            groupBox1.Controls.Add(txtTenBan);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(48, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 405);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bàn";
            // 
            // chkHoatDong
            // 
            chkHoatDong.AutoSize = true;
            chkHoatDong.Location = new Point(36, 335);
            chkHoatDong.Name = "chkHoatDong";
            chkHoatDong.Size = new Size(103, 24);
            chkHoatDong.TabIndex = 28;
            chkHoatDong.Text = "Hoạt động";
            chkHoatDong.UseVisualStyleBackColor = true;
            // 
            // numSoChoNgoi
            // 
            numSoChoNgoi.Location = new Point(36, 271);
            numSoChoNgoi.Name = "numSoChoNgoi";
            numSoChoNgoi.Size = new Size(243, 27);
            numSoChoNgoi.TabIndex = 27;
            // 
            // cbTrangThai
            // 
            cbTrangThai.FormattingEnabled = true;
            cbTrangThai.Location = new Point(36, 198);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.Size = new Size(305, 28);
            cbTrangThai.TabIndex = 26;
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(38, 118);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(303, 27);
            txtTenBan.TabIndex = 25;
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(38, 54);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(303, 27);
            txtMaSo.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 248);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 24;
            label4.Text = "Số chổ ngồi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 160);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 24;
            label3.Text = "Trạng Thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 95);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 24;
            label2.Text = "Tên Bàn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 24;
            label1.Text = "Mã bàn";
            // 
            // frmdatban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 644);
            Controls.Add(dgvBan);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Name = "frmdatban";
            Text = "frmdatban";
            Load += frmdatban_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoChoNgoi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBan;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private GroupBox groupBox1;
        private ComboBox cbTrangThai;
        private TextBox txtTenBan;
        private TextBox txtMaSo;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkHoatDong;
        private NumericUpDown numSoChoNgoi;
        private Label label4;
    }
}