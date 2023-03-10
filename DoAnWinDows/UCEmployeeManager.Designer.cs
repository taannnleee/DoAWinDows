namespace DoAnWinDows
{
    partial class UCEmployeeManager
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateTimeDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tblEmail = new System.Windows.Forms.Label();
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
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(84, 396);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(199, 23);
            this.txtSalary.TabIndex = 253;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(17, 399);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(38, 15);
            this.lblSalary.TabIndex = 252;
            this.lblSalary.Text = "Salary";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 65);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 23);
            this.txtID.TabIndex = 251;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(11, 73);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 250;
            this.lblID.Text = "ID";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.comboBoxGender.Location = new System.Drawing.Point(84, 347);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(199, 23);
            this.comboBoxGender.TabIndex = 249;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 350);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 248;
            this.lblGender.Text = "Gender";
            // 
            // dateTimeDateOfBirth
            // 
            this.dateTimeDateOfBirth.Location = new System.Drawing.Point(83, 312);
            this.dateTimeDateOfBirth.Name = "dateTimeDateOfBirth";
            this.dateTimeDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dateTimeDateOfBirth.TabIndex = 247;
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Location = new System.Drawing.Point(17, 318);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(67, 15);
            this.lblDateofbirth.TabIndex = 246;
            this.lblDateofbirth.Text = "Dateofbirth";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(83, 273);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(199, 23);
            this.txtAddress.TabIndex = 245;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 23);
            this.txtEmail.TabIndex = 244;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 281);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 243;
            this.lblAddress.Text = "Address";
            // 
            // tblEmail
            // 
            this.tblEmail.AutoSize = true;
            this.tblEmail.Location = new System.Drawing.Point(17, 240);
            this.tblEmail.Name = "tblEmail";
            this.tblEmail.Size = new System.Drawing.Size(36, 15);
            this.tblEmail.TabIndex = 242;
            this.tblEmail.Text = "Email";
            // 
            // gvQuanLy
            // 
            this.gvQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQuanLy.Location = new System.Drawing.Point(305, 44);
            this.gvQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvQuanLy.Name = "gvQuanLy";
            this.gvQuanLy.RowHeadersWidth = 51;
            this.gvQuanLy.RowTemplate.Height = 29;
            this.gvQuanLy.Size = new System.Drawing.Size(485, 326);
            this.gvQuanLy.TabIndex = 241;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.Location = new System.Drawing.Point(595, 399);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 25);
            this.btnSua.TabIndex = 240;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(284, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 33);
            this.label3.TabIndex = 239;
            this.label3.Text = "EmployerManager";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Location = new System.Drawing.Point(456, 399);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 25);
            this.btnXoa.TabIndex = 238;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Location = new System.Drawing.Point(342, 401);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 25);
            this.btnThem.TabIndex = 237;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtIdentitycard
            // 
            this.txtIdentitycard.Location = new System.Drawing.Point(83, 203);
            this.txtIdentitycard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdentitycard.Name = "txtIdentitycard";
            this.txtIdentitycard.Size = new System.Drawing.Size(199, 23);
            this.txtIdentitycard.TabIndex = 235;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(83, 161);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 23);
            this.txtPhone.TabIndex = 236;
            // 
            // lblIdentitycard
            // 
            this.lblIdentitycard.AutoSize = true;
            this.lblIdentitycard.Location = new System.Drawing.Point(11, 206);
            this.lblIdentitycard.Name = "lblIdentitycard";
            this.lblIdentitycard.Size = new System.Drawing.Size(70, 15);
            this.lblIdentitycard.TabIndex = 232;
            this.lblIdentitycard.Text = "Identitycard";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 23);
            this.txtName.TabIndex = 234;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 164);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 233;
            this.lblPhone.Text = "Phone";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(11, 114);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(58, 15);
            this.lblFullName.TabIndex = 231;
            this.lblFullName.Text = "FullName";
            // 
            // USEmployeeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dateTimeDateOfBirth);
            this.Controls.Add(this.lblDateofbirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tblEmail);
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
            this.Name = "USEmployeeManager";
            this.Size = new System.Drawing.Size(691, 512);
            ((System.ComponentModel.ISupportInitialize)(this.gvQuanLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSalary;
        private Label lblSalary;
        private TextBox txtID;
        private Label lblID;
        private ComboBox comboBoxGender;
        private Label lblGender;
        private DateTimePicker dateTimeDateOfBirth;
        private Label lblDateofbirth;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Label lblAddress;
        private Label tblEmail;
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
