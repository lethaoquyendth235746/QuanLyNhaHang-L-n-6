namespace QuanLyNhaHang
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            txtten = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnDangNhap = new Button();
            panel1 = new Panel();
            btndong = new Button();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtmatkhau = new TextBox();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnHuyBo = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtten
            // 
            txtten.Location = new Point(22, 343);
            txtten.Multiline = true;
            txtten.Name = "txtten";
            txtten.Size = new Size(393, 38);
            txtten.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 224);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "Weclcome back!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 315);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.OrangeRed;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(22, 498);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(165, 58);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btndong);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 35);
            panel1.TabIndex = 3;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.FlatStyle = FlatStyle.Flat;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndong.Location = new Point(383, 3);
            btndong.Name = "btndong";
            btndong.Size = new Size(45, 29);
            btndong.TabIndex = 0;
            btndong.Text = "X";
            btndong.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 125;
            iconPictureBox1.InitialImage = (Image)resources.GetObject("iconPictureBox1.InitialImage");
            iconPictureBox1.Location = new Point(158, 93);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(125, 128);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(22, 419);
            txtmatkhau.Multiline = true;
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(393, 38);
            txtmatkhau.TabIndex = 0;
            txtmatkhau.KeyDown += txtmatkhau_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 393);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(166, 101);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 29);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.OrangeRed;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            btnHuyBo.ForeColor = SystemColors.ButtonHighlight;
            btnHuyBo.Location = new Point(250, 498);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(165, 58);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(431, 689);
            Controls.Add(btnHuyBo);
            Controls.Add(iconButton1);
            Controls.Add(iconPictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtmatkhau);
            Controls.Add(label1);
            Controls.Add(txtten);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtten;
        private Label label1;
        private Label label2;
        private Button btnDangNhap;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btndong;
        private TextBox txtmatkhau;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Button btnHuyBo;
    }
}