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
            label1 = new Label();
            label2 = new Label();
            txtIDCardRemitter = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            txtMoneySend = new TextBox();
            label4 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 40);
            label1.Name = "label1";
            label1.Size = new Size(258, 43);
            label1.TabIndex = 0;
            label1.Text = "TRANSACTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 118);
            label2.Name = "label2";
            label2.Size = new Size(251, 20);
            label2.TabIndex = 1;
            label2.Text = "Please enter identity card of remitter";
            // 
            // txtIDCardRemitter
            // 
            txtIDCardRemitter.Location = new Point(204, 164);
            txtIDCardRemitter.Name = "txtIDCardRemitter";
            txtIDCardRemitter.Size = new Size(328, 27);
            txtIDCardRemitter.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 277);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 231);
            label3.Name = "label3";
            label3.Size = new Size(250, 20);
            label3.TabIndex = 3;
            label3.Text = "Please enter identity card of receiver";
            // 
            // txtMoneySend
            // 
            txtMoneySend.Location = new Point(204, 405);
            txtMoneySend.Name = "txtMoneySend";
            txtMoneySend.Size = new Size(328, 27);
            txtMoneySend.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(204, 359);
            label4.Name = "label4";
            label4.Size = new Size(191, 20);
            label4.TabIndex = 5;
            label4.Text = "Please enter money to send";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(316, 484);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // UCTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSend);
            Controls.Add(txtMoneySend);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(txtIDCardRemitter);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCTransactions";
            Size = new Size(807, 581);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIDCardRemitter;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtMoneySend;
        private Label label4;
        private Button btnSend;
    }
}
