namespace QuanLyNhaHang
{
    partial class frmdshienthoics
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
            btnThemMatHang = new FontAwesome.Sharp.IconButton();
            btnXoa = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new TextBox();
            dgvMatHang = new DataGridView();
            picTimKiem = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            SuspendLayout();
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
            btnThemMatHang.Location = new Point(1131, 89);
            btnThemMatHang.Name = "btnThemMatHang";
            btnThemMatHang.Size = new Size(205, 44);
            btnThemMatHang.TabIndex = 3;
            btnThemMatHang.Text = "Thêm mặt hàng";
            btnThemMatHang.UseVisualStyleBackColor = false;
            btnThemMatHang.Click += btnThemMatHang_Click;
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
            btnXoa.Location = new Point(1352, 89);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(121, 44);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(229, 99);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(313, 27);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvMatHang
            // 
            dgvMatHang.AllowUserToAddRows = false;
            dgvMatHang.AllowUserToDeleteRows = false;
            dgvMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatHang.BackgroundColor = Color.White;
            dgvMatHang.BorderStyle = BorderStyle.None;
            dgvMatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatHang.Location = new Point(230, 167);
            dgvMatHang.MultiSelect = false;
            dgvMatHang.Name = "dgvMatHang";
            dgvMatHang.ReadOnly = true;
            dgvMatHang.RowHeadersVisible = false;
            dgvMatHang.RowHeadersWidth = 51;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.Size = new Size(1243, 512);
            dgvMatHang.TabIndex = 5;
//            dgvMatHang.CellContentDoubleClick += dgvMatHang_CellContentDoubleClick;
            dgvMatHang.CellDoubleClick += dgvMatHang_CellDoubleClick;
            // 
            // picTimKiem
            // 
            picTimKiem.BackColor = Color.White;
            picTimKiem.ForeColor = SystemColors.ControlText;
            picTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            picTimKiem.IconColor = SystemColors.ControlText;
            picTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTimKiem.IconSize = 27;
            picTimKiem.Location = new Point(548, 99);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(28, 27);
            picTimKiem.TabIndex = 6;
            picTimKiem.TabStop = false;
            // 
            // frmdshienthoics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1588, 767);
            Controls.Add(picTimKiem);
            Controls.Add(dgvMatHang);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnThemMatHang);
            Name = "frmdshienthoics";
            Text = "frmdshienthoics";
            Load += frmdshienthoics_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnThemMatHang;
        private FontAwesome.Sharp.IconButton btnXoa;
        private TextBox txtTimKiem;
        private DataGridView dgvMatHang;
        private FontAwesome.Sharp.IconPictureBox picTimKiem;
    }
}