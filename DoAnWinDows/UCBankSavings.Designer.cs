namespace DoAnWinDows
{
    partial class UCBankSavings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSendingTime = new System.Windows.Forms.ComboBox();
            this.lblSendingTime = new System.Windows.Forms.Label();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateTimeSentDate = new System.Windows.Forms.DateTimePicker();
            this.lblSentDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tblEmail = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.gvQuanLy = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtIdentitycard = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblIdentitycard = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSendingTime
            // 
            this.comboBoxSendingTime.AutoCompleteCustomSource.AddRange(new string[] {
            "3 months => 3.0 %",
            "6 months => 3.5 %",
            "9 months => 4.0 %",
            "12 months => 4.5 %"});
            this.comboBoxSendingTime.FormattingEnabled = true;
            this.comboBoxSendingTime.Items.AddRange(new object[] {
            "3 months => 3.0 %",
            "6 months => 3.5 %",
            "9 months => 4.0 %",
            "12 months => 4.5 %"});
            this.comboBoxSendingTime.Location = new System.Drawing.Point(114, 359);
            this.comboBoxSendingTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSendingTime.Name = "comboBoxSendingTime";
            this.comboBoxSendingTime.Size = new System.Drawing.Size(227, 28);
            this.comboBoxSendingTime.TabIndex = 257;
            // 
            // lblSendingTime
            // 
            this.lblSendingTime.AutoSize = true;
            this.lblSendingTime.Location = new System.Drawing.Point(17, 359);
            this.lblSendingTime.Name = "lblSendingTime";
            this.lblSendingTime.Size = new System.Drawing.Size(96, 20);
            this.lblSendingTime.TabIndex = 256;
            this.lblSendingTime.Text = "SendingTime";
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(148, 509);
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(193, 27);
            this.txtDepositAmount.TabIndex = 255;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(17, 509);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(114, 20);
            this.lblDepositAmount.TabIndex = 254;
            this.lblDepositAmount.Text = "DepositAmount";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxGender.Location = new System.Drawing.Point(114, 459);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(227, 28);
            this.comboBoxGender.TabIndex = 253;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 459);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 252;
            this.lblGender.Text = "Gender";
            // 
            // dateTimeSentDate
            // 
            this.dateTimeSentDate.Location = new System.Drawing.Point(114, 409);
            this.dateTimeSentDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeSentDate.Name = "dateTimeSentDate";
            this.dateTimeSentDate.Size = new System.Drawing.Size(228, 27);
            this.dateTimeSentDate.TabIndex = 251;
            // 
            // lblSentDate
            // 
            this.lblSentDate.AutoSize = true;
            this.lblSentDate.Location = new System.Drawing.Point(17, 409);
            this.lblSentDate.Name = "lblSentDate";
            this.lblSentDate.Size = new System.Drawing.Size(72, 20);
            this.lblSentDate.TabIndex = 250;
            this.lblSentDate.Text = "Sent date";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 309);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 27);
            this.txtAddress.TabIndex = 249;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 27);
            this.txtEmail.TabIndex = 248;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(114, 209);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(227, 27);
            this.txtJob.TabIndex = 247;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 309);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 246;
            this.lblAddress.Text = "Address";
            // 
            // tblEmail
            // 
            this.tblEmail.AutoSize = true;
            this.tblEmail.Location = new System.Drawing.Point(17, 259);
            this.tblEmail.Name = "tblEmail";
            this.tblEmail.Size = new System.Drawing.Size(46, 20);
            this.tblEmail.TabIndex = 245;
            this.tblEmail.Text = "Email";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(17, 209);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(32, 20);
            this.lblJob.TabIndex = 244;
            this.lblJob.Text = "Job";
            // 
            // gvQuanLy
            // 
            this.gvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuanLy.Location = new System.Drawing.Point(367, 59);
            this.gvQuanLy.Name = "gvQuanLy";
            this.gvQuanLy.RowHeadersWidth = 51;
            this.gvQuanLy.RowTemplate.Height = 29;
            this.gvQuanLy.Size = new System.Drawing.Size(554, 435);
            this.gvQuanLy.TabIndex = 243;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(530, 507);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 33);
            this.btnSua.TabIndex = 242;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(343, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 42);
            this.label3.TabIndex = 241;
            this.label3.Text = "BankSavings";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(640, 507);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 33);
            this.btnXoa.TabIndex = 240;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(430, 507);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 33);
            this.btnThem.TabIndex = 239;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtIdentitycard
            // 
            this.txtIdentitycard.Location = new System.Drawing.Point(114, 159);
            this.txtIdentitycard.Name = "txtIdentitycard";
            this.txtIdentitycard.Size = new System.Drawing.Size(227, 27);
            this.txtIdentitycard.TabIndex = 237;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 109);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 27);
            this.txtPhone.TabIndex = 238;
            // 
            // lblIdentitycard
            // 
            this.lblIdentitycard.AutoSize = true;
            this.lblIdentitycard.Location = new System.Drawing.Point(17, 159);
            this.lblIdentitycard.Name = "lblIdentitycard";
            this.lblIdentitycard.Size = new System.Drawing.Size(88, 20);
            this.lblIdentitycard.TabIndex = 234;
            this.lblIdentitycard.Text = "Identitycard";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 27);
            this.txtName.TabIndex = 236;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 109);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 235;
            this.lblPhone.Text = "Phone";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 59);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(72, 20);
            this.lblFullName.TabIndex = 233;
            this.lblFullName.Text = "FullName";
            // 
            // UCBankSavings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSendingTime);
            this.Controls.Add(this.lblSendingTime);
            this.Controls.Add(this.txtDepositAmount);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dateTimeSentDate);
            this.Controls.Add(this.lblSentDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tblEmail);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.gvQuanLy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtIdentitycard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblIdentitycard);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFullName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCBankSavings";
            this.Size = new System.Drawing.Size(810, 559);
            this.Load += new System.EventHandler(this.UCBankSavings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxSendingTime;
        private Label lblSendingTime;
        private TextBox txtDepositAmount;
        private Label lblDepositAmount;
        private ComboBox comboBoxGender;
        private Label lblGender;
        private DateTimePicker dateTimeSentDate;
        private Label lblSentDate;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtJob;
        private Label lblAddress;
        private Label tblEmail;
        private Label lblJob;
        private DataGridView gvQuanLy;
        private Button btnSua;
        private Label label3;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtIdentitycard;
        private TextBox txtPhone;
        private Label lblIdentitycard;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblFullName;
    }
}
