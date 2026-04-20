namespace QuanLyNhaHang
{
    partial class frmthemkhachhang
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
            txtDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLuu = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            labQuayLai = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(68, 235);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(420, 27);
            txtDienThoai.TabIndex = 6;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(68, 151);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(420, 27);
            txtHoTen.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(68, 197);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 3;
            label2.Text = "Số điện thoại (*)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(68, 116);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 4;
            label1.Text = "Họ và Tên (*)";
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
            btnLuu.Location = new Point(367, 392);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(121, 44);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu lại";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(-484, 403);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 8;
            label8.Text = "<<Quay lại";
            // 
            // labQuayLai
            // 
            labQuayLai.AutoSize = true;
            labQuayLai.Font = new Font("Segoe UI", 10.2F);
            labQuayLai.Location = new Point(68, 403);
            labQuayLai.Name = "labQuayLai";
            labQuayLai.Size = new Size(96, 23);
            labQuayLai.TabIndex = 10;
            labQuayLai.Text = "<<Quay lại";
            labQuayLai.Click += labQuayLai_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 37);
            label4.Name = "label4";
            label4.Size = new Size(210, 31);
            label4.TabIndex = 4;
            label4.Text = "Thêm Khách Hàng";
            // 
            // frmthemkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 582);
            Controls.Add(labQuayLai);
            Controls.Add(btnLuu);
            Controls.Add(label8);
            Controls.Add(txtDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmthemkhachhang";
            Text = "frmthemkhachhang";
            Load += frmthemkhachhang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatKhau;
        private TextBox txtDienThoai;
        private TextBox txtHoTen;
        private Label label10;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnLuu;
        private Label label8;
        private Label labQuayLai;
        private Label label4;
    }
}