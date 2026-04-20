namespace QuanLyNhaHang
{
    partial class frmChonMon
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
            dgvMon = new DataGridView();
            btnChon = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btnHuy = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            picTimKiem = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            SuspendLayout();
            // 
            // dgvMon
            // 
            dgvMon.AllowUserToAddRows = false;
            dgvMon.AllowUserToDeleteRows = false;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.BackgroundColor = Color.White;
            dgvMon.BorderStyle = BorderStyle.None;
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(94, 169);
            dgvMon.MultiSelect = false;
            dgvMon.Name = "dgvMon";
            dgvMon.ReadOnly = true;
            dgvMon.RowHeadersVisible = false;
            dgvMon.RowHeadersWidth = 51;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.Size = new Size(1253, 323);
            dgvMon.TabIndex = 13;
            dgvMon.CurrentCellDirtyStateChanged += dgvMon_CurrentCellDirtyStateChanged;
            // 
            // btnChon
            // 
            btnChon.IconChar = FontAwesome.Sharp.IconChar.None;
            btnChon.IconColor = Color.Black;
            btnChon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnChon.Location = new Point(1249, 531);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(106, 47);
            btnChon.TabIndex = 14;
            btnChon.Text = "Thêm";
            btnChon.UseVisualStyleBackColor = true;
            btnChon.Click += btnChon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(583, 24);
            label1.Name = "label1";
            label1.Size = new Size(295, 50);
            label1.TabIndex = 15;
            label1.Text = "Thêm mặt hàng";
            // 
            // btnHuy
            // 
            btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHuy.IconColor = Color.Black;
            btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHuy.Location = new Point(1128, 531);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(106, 47);
            btnHuy.TabIndex = 16;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(833, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 50);
            textBox1.TabIndex = 17;
            // 
            // picTimKiem
            // 
            picTimKiem.BackColor = Color.White;
            picTimKiem.ForeColor = SystemColors.ControlText;
            picTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            picTimKiem.IconColor = SystemColors.ControlText;
            picTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picTimKiem.IconSize = 27;
            picTimKiem.Location = new Point(833, 113);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(28, 27);
            picTimKiem.TabIndex = 18;
            picTimKiem.TabStop = false;
            // 
            // frmChonMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1423, 610);
            Controls.Add(picTimKiem);
            Controls.Add(textBox1);
            Controls.Add(btnHuy);
            Controls.Add(label1);
            Controls.Add(btnChon);
            Controls.Add(dgvMon);
            Name = "frmChonMon";
            Text = "frmChonMon";
            Load += frmChonMon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMon;
        private FontAwesome.Sharp.IconButton btnChon;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnHuy;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox picTimKiem;
    }
}