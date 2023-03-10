namespace DoAnWinDows
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnKhach = new System.Windows.Forms.RadioButton();
            this.rbtnQuanLy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(289, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "NGAN HANG DAT";
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.Location = new System.Drawing.Point(472, 318);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 25);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AutoSize = true;
            this.btnDangNhap.Location = new System.Drawing.Point(289, 318);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(82, 25);
            this.btnDangNhap.TabIndex = 24;
            this.btnDangNhap.Text = "Dang nhap";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(364, 262);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(199, 23);
            this.txtMatKhau.TabIndex = 23;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(364, 203);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(199, 23);
            this.txtTenDangNhap.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mat khau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ten dang nhap";
            // 
            // rbtnKhach
            // 
            this.rbtnKhach.AutoSize = true;
            this.rbtnKhach.Location = new System.Drawing.Point(484, 161);
            this.rbtnKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnKhach.Name = "rbtnKhach";
            this.rbtnKhach.Size = new System.Drawing.Size(58, 19);
            this.rbtnKhach.TabIndex = 19;
            this.rbtnKhach.TabStop = true;
            this.rbtnKhach.Text = "Khach";
            this.rbtnKhach.UseVisualStyleBackColor = true;
            // 
            // rbtnQuanLy
            // 
            this.rbtnQuanLy.AutoSize = true;
            this.rbtnQuanLy.Location = new System.Drawing.Point(326, 161);
            this.rbtnQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnQuanLy.Name = "rbtnQuanLy";
            this.rbtnQuanLy.Size = new System.Drawing.Size(66, 19);
            this.rbtnQuanLy.TabIndex = 18;
            this.rbtnQuanLy.TabStop = true;
            this.rbtnQuanLy.Text = "Quan ly";
            this.rbtnQuanLy.UseVisualStyleBackColor = true;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnKhach);
            this.Controls.Add(this.rbtnQuanLy);
            this.Name = "FLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnThoat;
        private Button btnDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label2;
        private Label label1;
        private RadioButton rbtnKhach;
        private RadioButton rbtnQuanLy;
    }
}