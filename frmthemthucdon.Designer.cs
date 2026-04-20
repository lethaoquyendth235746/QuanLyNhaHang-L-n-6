namespace QuanLyNhaHang
{
    partial class frmthemthucdon
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
            panel1 = new Panel();
            btnThemMatHang = new FontAwesome.Sharp.IconButton();
            dgvMon = new DataGridView();
            txtThuTu = new TextBox();
            btnLuu = new FontAwesome.Sharp.IconButton();
            txtTenThucDon = new TextBox();
            label8 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnThemMatHang);
            panel1.Controls.Add(dgvMon);
            panel1.Controls.Add(txtThuTu);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtTenThucDon);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1439, 640);
            panel1.TabIndex = 1;
            // 
            // btnThemMatHang
            // 
            btnThemMatHang.BackColor = Color.RoyalBlue;
            btnThemMatHang.FlatStyle = FlatStyle.Flat;
            btnThemMatHang.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMatHang.ForeColor = Color.White;
            btnThemMatHang.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnThemMatHang.IconColor = Color.White;
            btnThemMatHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemMatHang.IconSize = 30;
            btnThemMatHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMatHang.Location = new Point(30, 144);
            btnThemMatHang.Name = "btnThemMatHang";
            btnThemMatHang.Size = new Size(205, 44);
            btnThemMatHang.TabIndex = 13;
            btnThemMatHang.Text = "Thêm mặt hàng";
            btnThemMatHang.UseVisualStyleBackColor = false;
            btnThemMatHang.Click += btnThemMatHang_Click;
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.BorderStyle = BorderStyle.None;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(30, 239);
            dgvMon.MultiSelect = false;
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersVisible = false;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(1243, 302);
            dgvMon.TabIndex = 12;
            // 
            // txtThuTu
            // 
            txtThuTu.Location = new Point(565, 91);
            txtThuTu.Name = "txtThuTu";
            txtThuTu.Size = new Size(420, 27);
            txtThuTu.TabIndex = 3;
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
            btnLuu.Location = new Point(1112, 566);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 44);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtTenThucDon
            // 
            txtTenThucDon.Location = new Point(30, 91);
            txtTenThucDon.Name = "txtTenThucDon";
            txtTenThucDon.Size = new Size(420, 27);
            txtTenThucDon.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(30, 577);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 0;
            label8.Text = "<<Quay lại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(565, 56);
            label3.Name = "label3";
            label3.Size = new Size(145, 23);
            label3.TabIndex = 0;
            label3.Text = "Thứ tự sắp xếp (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên thực đơn  (*)";
            // 
            // frmthemthucdon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 708);
            Controls.Add(panel1);
            Name = "frmthemthucdon";
            Text = "frmthemthucdon";
            Load += frmthemthucdon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLuu;
        private TextBox txtTenThucDon;
        private Label label8;
        private Label label3;
        private Label label1;
        private TextBox txtThuTu;
        private DataGridView dgvMon;
        private FontAwesome.Sharp.IconButton btnThemMatHang;
    }
}