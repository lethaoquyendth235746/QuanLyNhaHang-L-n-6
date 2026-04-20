namespace QuanLyNhaHang
{
    partial class frmthucdon
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
            dgvThucDon = new DataGridView();
            picTimKiem = new FontAwesome.Sharp.IconPictureBox();
            txtTimKiem = new TextBox();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            SuspendLayout();
            // 
            // dgvThucDon
            // 
            dgvThucDon.AllowUserToAddRows = false;
            dgvThucDon.AllowUserToDeleteRows = false;
            dgvThucDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThucDon.BackgroundColor = Color.White;
            dgvThucDon.BorderStyle = BorderStyle.None;
            dgvThucDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThucDon.Location = new Point(39, 110);
            dgvThucDon.MultiSelect = false;
            dgvThucDon.Name = "dgvThucDon";
            dgvThucDon.ReadOnly = true;
            dgvThucDon.RowHeadersVisible = false;
            dgvThucDon.RowHeadersWidth = 51;
            dgvThucDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucDon.Size = new Size(1243, 488);
            dgvThucDon.TabIndex = 16;
            dgvThucDon.CellContentClick += dgvThucDon_CellContentClick;
            // 
            // picTimKiem
            // 
            picTimKiem.BackColor = Color.White;
            picTimKiem.ForeColor = SystemColors.ControlText;
            picTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            picTimKiem.IconColor = SystemColors.ControlText;
            picTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTimKiem.IconSize = 27;
            picTimKiem.Location = new Point(357, 46);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(28, 27);
            picTimKiem.TabIndex = 15;
            picTimKiem.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(38, 46);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(313, 27);
            txtTimKiem.TabIndex = 14;
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
            btnXoa.Location = new Point(1161, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 44);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.Location = new Point(940, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(205, 44);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm thực đơn";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // frmthucdon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 635);
            Controls.Add(dgvThucDon);
            Controls.Add(picTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Name = "frmthucdon";
            Text = "frmthucdon";
            Load += frmthucdon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThucDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThucDon;
        private FontAwesome.Sharp.IconPictureBox picTimKiem;
        private TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}