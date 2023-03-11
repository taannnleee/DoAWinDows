namespace DoAnWinDows
{
    partial class FManager
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
            menuStrip1 = new MenuStrip();
            managerToolStripMenuItem = new ToolStripMenuItem();
            accountManagerToolStripMenuItem = new ToolStripMenuItem();
            employeeManagerToolStripMenuItem = new ToolStripMenuItem();
            utilitiesToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            rechargeToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            bankSavingsToolStripMenuItem = new ToolStripMenuItem();
            panelContainer = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { managerToolStripMenuItem, utilitiesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountManagerToolStripMenuItem, employeeManagerToolStripMenuItem });
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(82, 24);
            managerToolStripMenuItem.Text = "Manager";
            // 
            // accountManagerToolStripMenuItem
            // 
            accountManagerToolStripMenuItem.Name = "accountManagerToolStripMenuItem";
            accountManagerToolStripMenuItem.Size = new Size(221, 26);
            accountManagerToolStripMenuItem.Text = "Account Manager";
            accountManagerToolStripMenuItem.Click += accountManagerToolStripMenuItem_Click;
            // 
            // employeeManagerToolStripMenuItem
            // 
            employeeManagerToolStripMenuItem.Name = "employeeManagerToolStripMenuItem";
            employeeManagerToolStripMenuItem.Size = new Size(221, 26);
            employeeManagerToolStripMenuItem.Text = "Employee Manager";
            employeeManagerToolStripMenuItem.Click += employeeManagerToolStripMenuItem_Click;
            // 
            // utilitiesToolStripMenuItem
            // 
            utilitiesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { transactionsToolStripMenuItem, rechargeToolStripMenuItem, withdrawToolStripMenuItem, bankSavingsToolStripMenuItem });
            utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            utilitiesToolStripMenuItem.Size = new Size(73, 24);
            utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(174, 26);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // rechargeToolStripMenuItem
            // 
            rechargeToolStripMenuItem.Name = "rechargeToolStripMenuItem";
            rechargeToolStripMenuItem.Size = new Size(174, 26);
            rechargeToolStripMenuItem.Text = "Recharge";
            rechargeToolStripMenuItem.Click += rechargeToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(174, 26);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // bankSavingsToolStripMenuItem
            // 
            bankSavingsToolStripMenuItem.Name = "bankSavingsToolStripMenuItem";
            bankSavingsToolStripMenuItem.Size = new Size(174, 26);
            bankSavingsToolStripMenuItem.Text = "BankSavings";
            bankSavingsToolStripMenuItem.Click += bankSavingsToolStripMenuItem_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 36);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(914, 560);
            panelContainer.TabIndex = 1;
            // 
            // FManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FManager";
            Text = "Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managerToolStripMenuItem;
        private ToolStripMenuItem accountManagerToolStripMenuItem;
        private Panel panelContainer;
        private ToolStripMenuItem employeeManagerToolStripMenuItem;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem rechargeToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem bankSavingsToolStripMenuItem;
    }
}