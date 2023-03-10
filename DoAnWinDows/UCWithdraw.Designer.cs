namespace DoAnWinDows
{
    partial class UCWithdraw
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(212, 219);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(199, 23);
            this.txtAmount.TabIndex = 217;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(139, 227);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 216;
            this.lblAmount.Text = "Amount";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(212, 173);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(199, 23);
            this.txtPhone.TabIndex = 215;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 125);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 23);
            this.txtName.TabIndex = 214;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(142, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 213;
            this.lblPhone.Text = "Phone";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(136, 125);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(58, 15);
            this.lblFullName.TabIndex = 212;
            this.lblFullName.Text = "FullName";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(477, 28);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(100, 23);
            this.txtAccountBalance.TabIndex = 211;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(402, 372);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 210;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(369, 31);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(93, 15);
            this.lblAccountBalance.TabIndex = 209;
            this.lblAccountBalance.Text = "AccountBalance";
            // 
            // UCWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblAccountBalance);
            this.Name = "UCWithdraw";
            this.Size = new System.Drawing.Size(712, 423);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblFullName;
        private TextBox txtAccountBalance;
        private Button btnWithdraw;
        private Label lblAccountBalance;
    }
}
