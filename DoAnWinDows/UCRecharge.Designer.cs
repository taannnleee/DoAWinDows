namespace DoAnWinDows
{
    partial class UCRecharge
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
            this.components = new System.ComponentModel.Container();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowInfor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorInvalidNontification = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInvalidNontification)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(42, 244);
            this.btnRecharge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(135, 22);
            this.btnRecharge.TabIndex = 20;
            this.btnRecharge.Text = "Recharge";
            this.btnRecharge.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Recharge";
            // 
            // btnShowInfor
            // 
            this.btnShowInfor.Location = new System.Drawing.Point(42, 197);
            this.btnShowInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowInfor.Name = "btnShowInfor";
            this.btnShowInfor.Size = new System.Drawing.Size(135, 22);
            this.btnShowInfor.TabIndex = 18;
            this.btnShowInfor.Text = "Show information";
            this.btnShowInfor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(432, 80);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Show information";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(42, 155);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(189, 23);
            this.txtAccountNumber.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter account number";
            // 
            // errorInvalidNontification
            // 
            this.errorInvalidNontification.ContainerControl = this;
            // 
            // UCRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShowInfor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "UCRecharge";
            this.Size = new System.Drawing.Size(701, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInvalidNontification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRecharge;
        private Label label3;
        private Button btnShowInfor;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtAccountNumber;
        private Label label1;
        private ErrorProvider errorInvalidNontification;
    }
}
