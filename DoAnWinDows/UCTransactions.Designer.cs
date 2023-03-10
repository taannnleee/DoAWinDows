namespace DoAnWinDows
{
    partial class UCTransactions
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtRecipientAccountNumber = new System.Windows.Forms.TextBox();
            this.lblRecipientAccountNumber = new System.Windows.Forms.Label();
            this.txtSenderAccountNumber = new System.Windows.Forms.TextBox();
            this.lblSenderAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(387, 262);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 23);
            this.txtMessage.TabIndex = 17;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(220, 262);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 15);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Message";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(290, 341);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 23);
            this.btnTransfer.TabIndex = 15;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(387, 211);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 14;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(220, 211);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 15);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount";
            // 
            // txtRecipientAccountNumber
            // 
            this.txtRecipientAccountNumber.Location = new System.Drawing.Point(387, 136);
            this.txtRecipientAccountNumber.Name = "txtRecipientAccountNumber";
            this.txtRecipientAccountNumber.Size = new System.Drawing.Size(100, 23);
            this.txtRecipientAccountNumber.TabIndex = 12;
            // 
            // lblRecipientAccountNumber
            // 
            this.lblRecipientAccountNumber.AutoSize = true;
            this.lblRecipientAccountNumber.Location = new System.Drawing.Point(220, 139);
            this.lblRecipientAccountNumber.Name = "lblRecipientAccountNumber";
            this.lblRecipientAccountNumber.Size = new System.Drawing.Size(145, 15);
            this.lblRecipientAccountNumber.TabIndex = 11;
            this.lblRecipientAccountNumber.Text = "RecipientAccountNumber";
            // 
            // txtSenderAccountNumber
            // 
            this.txtSenderAccountNumber.Location = new System.Drawing.Point(387, 72);
            this.txtSenderAccountNumber.Name = "txtSenderAccountNumber";
            this.txtSenderAccountNumber.Size = new System.Drawing.Size(100, 23);
            this.txtSenderAccountNumber.TabIndex = 10;
            // 
            // lblSenderAccountNumber
            // 
            this.lblSenderAccountNumber.AutoSize = true;
            this.lblSenderAccountNumber.Location = new System.Drawing.Point(220, 72);
            this.lblSenderAccountNumber.Name = "lblSenderAccountNumber";
            this.lblSenderAccountNumber.Size = new System.Drawing.Size(132, 15);
            this.lblSenderAccountNumber.TabIndex = 9;
            this.lblSenderAccountNumber.Text = "SenderAccountNumber";
            // 
            // UCTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtRecipientAccountNumber);
            this.Controls.Add(this.lblRecipientAccountNumber);
            this.Controls.Add(this.txtSenderAccountNumber);
            this.Controls.Add(this.lblSenderAccountNumber);
            this.Name = "UCTransactions";
            this.Size = new System.Drawing.Size(706, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMessage;
        private Label lblMessage;
        private Button btnTransfer;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtRecipientAccountNumber;
        private Label lblRecipientAccountNumber;
        private TextBox txtSenderAccountNumber;
        private Label lblSenderAccountNumber;
    }
}
