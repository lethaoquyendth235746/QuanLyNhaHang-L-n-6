namespace QuanLyNhaHang
{
    partial class frmThemmoidanhmuc
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDanhMuc = new TextBox();
            txtMoTa = new TextBox();
            btnLuu = new FontAwesome.Sharp.IconButton();
            btnTrolai = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 34);
            label1.Name = "label1";
            label1.Size = new Size(342, 31);
            label1.TabIndex = 0;
            label1.Text = "Thêm mới danh mục mặt hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 93);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên danh mục (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(399, 93);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 0;
            label3.Text = "Mô tả thêm";
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.Location = new Point(48, 134);
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.Size = new Size(298, 27);
            txtTenDanhMuc.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(399, 134);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(298, 27);
            txtMoTa.TabIndex = 1;
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
            btnLuu.Location = new Point(575, 200);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 44);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTrolai
            // 
            btnTrolai.BackColor = Color.AliceBlue;
            btnTrolai.FlatAppearance.BorderSize = 0;
            btnTrolai.FlatStyle = FlatStyle.Flat;
            btnTrolai.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrolai.ForeColor = Color.Black;
            btnTrolai.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnTrolai.IconColor = Color.Black;
            btnTrolai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrolai.IconSize = 30;
            btnTrolai.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrolai.Location = new Point(448, 200);
            btnTrolai.Name = "btnTrolai";
            btnTrolai.Size = new Size(121, 44);
            btnTrolai.TabIndex = 3;
            btnTrolai.Text = "Trở lại";
            btnTrolai.UseVisualStyleBackColor = false;
            btnTrolai.Click += btnTrolai_Click;
            // 
            // frmThemmoidanhmuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(743, 273);
            Controls.Add(btnTrolai);
            Controls.Add(btnLuu);
            Controls.Add(txtMoTa);
            Controls.Add(txtTenDanhMuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmThemmoidanhmuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThemmoidanhmuc";
            Load += frmThemmoidanhmuc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenDanhMuc;
        private TextBox txtMoTa;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnTrolai;
    }
}