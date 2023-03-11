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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtIdentityCard = new TextBox();
            gvInformation = new DataGridView();
            btnSearch = new Button();
            btnWithdraw = new Button();
            txtMoneyWithdraw = new TextBox();
            label3 = new Label();
            errorIdentityCard = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)gvInformation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorIdentityCard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(228, 43);
            label1.TabIndex = 0;
            label1.Text = "WITHDRAW";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 120);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 1;
            label2.Text = "Please enter your Identity Card";
            // 
            // txtIdentityCard
            // 
            txtIdentityCard.Location = new Point(48, 162);
            txtIdentityCard.Name = "txtIdentityCard";
            txtIdentityCard.Size = new Size(309, 27);
            txtIdentityCard.TabIndex = 2;
            // 
            // gvInformation
            // 
            gvInformation.AllowUserToAddRows = false;
            gvInformation.AllowUserToDeleteRows = false;
            gvInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInformation.Location = new Point(48, 218);
            gvInformation.Name = "gvInformation";
            gvInformation.ReadOnly = true;
            gvInformation.RowHeadersWidth = 51;
            gvInformation.RowTemplate.Height = 29;
            gvInformation.Size = new Size(686, 92);
            gvInformation.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(428, 162);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(428, 380);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(94, 32);
            btnWithdraw.TabIndex = 5;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // txtMoneyWithdraw
            // 
            txtMoneyWithdraw.Location = new Point(48, 385);
            txtMoneyWithdraw.Name = "txtMoneyWithdraw";
            txtMoneyWithdraw.Size = new Size(309, 27);
            txtMoneyWithdraw.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 343);
            label3.Name = "label3";
            label3.Size = new Size(221, 20);
            label3.TabIndex = 6;
            label3.Text = "Please enter money to withdraw";
            // 
            // errorIdentityCard
            // 
            errorIdentityCard.ContainerControl = this;
            // 
            // UCWithdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtMoneyWithdraw);
            Controls.Add(label3);
            Controls.Add(btnWithdraw);
            Controls.Add(btnSearch);
            Controls.Add(gvInformation);
            Controls.Add(txtIdentityCard);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCWithdraw";
            Size = new Size(814, 564);
            ((System.ComponentModel.ISupportInitialize)gvInformation).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorIdentityCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIdentityCard;
        private DataGridView gvInformation;
        private Button btnSearch;
        private Button btnWithdraw;
        private TextBox txtMoneyWithdraw;
        private Label label3;
        private ErrorProvider errorIdentityCard;
    }
}
