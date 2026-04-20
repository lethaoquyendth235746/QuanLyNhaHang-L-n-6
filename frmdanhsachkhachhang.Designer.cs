namespace QuanLyNhaHang
{
    partial class frmdanhsachkhachhang
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
            picTimKiem = new FontAwesome.Sharp.IconPictureBox();
            txtTimKiem = new TextBox();
            btnThemMoi = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            dgvKhacHang = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhacHang).BeginInit();
            SuspendLayout();
            // 
            // picTimKiem
            // 
            picTimKiem.BackColor = Color.White;
            picTimKiem.ForeColor = SystemColors.ControlText;
            picTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            picTimKiem.IconColor = SystemColors.ControlText;
            picTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTimKiem.IconSize = 27;
            picTimKiem.Location = new Point(1238, 147);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(28, 27);
            picTimKiem.TabIndex = 27;
            picTimKiem.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(953, 147);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(313, 27);
            txtTimKiem.TabIndex = 26;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.RoyalBlue;
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnThemMoi.IconColor = Color.White;
            btnThemMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemMoi.IconSize = 30;
            btnThemMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemMoi.Location = new Point(23, 130);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(251, 44);
            btnThemMoi.TabIndex = 25;
            btnThemMoi.Text = "Thêm mới khách hàng";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(1071, 78);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 29);
            iconButton2.TabIndex = 23;
            iconButton2.Text = "import";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(1171, 78);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 29);
            iconButton1.TabIndex = 24;
            iconButton1.Text = "Export";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // dgvKhacHang
            // 
            dgvKhacHang.AllowUserToAddRows = false;
            dgvKhacHang.AllowUserToDeleteRows = false;
            dgvKhacHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhacHang.BackgroundColor = Color.White;
            dgvKhacHang.BorderStyle = BorderStyle.None;
            dgvKhacHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhacHang.Location = new Point(23, 207);
            dgvKhacHang.MultiSelect = false;
            dgvKhacHang.Name = "dgvKhacHang";
            dgvKhacHang.ReadOnly = true;
            dgvKhacHang.RowHeadersVisible = false;
            dgvKhacHang.RowHeadersWidth = 51;
            dgvKhacHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhacHang.Size = new Size(1243, 289);
            dgvKhacHang.TabIndex = 22;
            dgvKhacHang.CellClick += dgvKhacHang_CellClick;
            // 
            // frmdanhsachkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 676);
            Controls.Add(picTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnThemMoi);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(dgvKhacHang);
            Name = "frmdanhsachkhachhang";
            Text = "frmdanhsachkhachhang";
            Load += frmdanhsachkhachhang_Load;
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhacHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picTimKiem;
        private TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView dgvKhacHang;
    }
}