namespace QuanLyNhaHang
{
    partial class frmdanhsachnhanvien
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
            dgvNhanVien = new DataGridView();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            picTimKiem = new FontAwesome.Sharp.IconPictureBox();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(25, 175);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1243, 289);
            dgvNhanVien.TabIndex = 17;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1169, 55);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 29);
            iconButton1.TabIndex = 18;
            iconButton1.Text = "Export";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1069, 55);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 29);
            iconButton2.TabIndex = 18;
            iconButton2.Text = "import";
            iconButton2.UseVisualStyleBackColor = true;
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
            btnThem.Location = new Point(25, 98);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(205, 44);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm mặt hàng";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // picTimKiem
            // 
            picTimKiem.BackColor = Color.White;
            picTimKiem.ForeColor = SystemColors.ControlText;
            picTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            picTimKiem.IconColor = SystemColors.ControlText;
            picTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTimKiem.IconSize = 27;
            picTimKiem.Location = new Point(1240, 115);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(28, 27);
            picTimKiem.TabIndex = 21;
            picTimKiem.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(955, 115);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(313, 27);
            txtSearch.TabIndex = 20;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // frmdanhsachnhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 617);
            Controls.Add(picTimKiem);
            Controls.Add(txtSearch);
            Controls.Add(btnThem);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(dgvNhanVien);
            Name = "frmdanhsachnhanvien";
            Text = "frmdanhsachnhanvien";
            Load += frmdanhsachnhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconPictureBox picTimKiem;
        private TextBox txtSearch;
    }
}