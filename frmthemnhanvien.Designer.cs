namespace QuanLyNhaHang
{
    partial class frmthemnhanvien
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
            btnLuu = new FontAwesome.Sharp.IconButton();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            cboVaiTro = new ComboBox();
            label4 = new Label();
            label11 = new Label();
            txtDienThoai = new TextBox();
            txtXacNhanMK = new TextBox();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            chkHienMK = new CheckBox();
            txtMatKhau = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(chkHienMK);
            panel1.Controls.Add(cboVaiTro);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtTaiKhoan);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtXacNhanMK);
            panel1.Controls.Add(txtDienThoai);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(57, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 640);
            panel1.TabIndex = 2;
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
            btnLuu.Location = new Point(881, 566);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 44);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(420, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(30, 91);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(420, 27);
            txtHoTen.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(30, 137);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ Email (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ tên nhân viên (*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(565, 315);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 0;
            label5.Text = "Vai trò (*)";
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(567, 351);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(418, 28);
            cboVaiTro.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(565, 137);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 0;
            label4.Text = "Số điện thoại (*)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(565, 223);
            label11.Name = "label11";
            label11.Size = new Size(180, 23);
            label11.TabIndex = 0;
            label11.Text = "Xác nhận mật khẩu (*)";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(565, 175);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(420, 27);
            txtDienThoai.TabIndex = 1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(565, 261);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(420, 27);
            txtXacNhanMK.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(565, 91);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(420, 27);
            txtTaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(565, 56);
            label3.Name = "label3";
            label3.Size = new Size(192, 23);
            label3.TabIndex = 0;
            label3.Text = "Tài khoản đăng nhập (*)";
            // 
            // chkHienMK
            // 
            chkHienMK.AutoSize = true;
            chkHienMK.Location = new Point(30, 294);
            chkHienMK.Name = "chkHienMK";
            chkHienMK.Size = new Size(148, 24);
            chkHienMK.TabIndex = 4;
            chkHienMK.Text = "Hiển thị mật khẩu";
            chkHienMK.UseVisualStyleBackColor = true;
            chkHienMK.CheckedChanged += chkHienMK_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(30, 261);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(420, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(30, 223);
            label10.Name = "label10";
            label10.Size = new Size(192, 23);
            label10.TabIndex = 0;
            label10.Text = "Mật khẩu đăng nhập (*)";
            // 
            // frmthemnhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1535, 735);
            Controls.Add(panel1);
            Name = "frmthemnhanvien";
            Text = "frmthemnhanvien";
            Load += frmthemnhanvien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnLuu;
        private TextBox txtHoTen;
        private Label label8;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private CheckBox chkHienMK;
        private ComboBox cboVaiTro;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private TextBox txtDienThoai;
        private Label label11;
        private Label label4;
        private Label label10;
        private Label label3;
        private Label label5;
    }
}