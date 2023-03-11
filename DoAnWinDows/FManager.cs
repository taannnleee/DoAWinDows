using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinDows
{
    public partial class FManager : Form
    {
        public FManager()
        {
            InitializeComponent();
        }

        public void AddUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void accountManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCAccountManager account = new UCAccountManager(); 
            AddUserControl(account);
        }

        private void employeeManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployeeManager employee = new UCEmployeeManager();
            AddUserControl(employee);
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCTransactions trans = new UCTransactions();
            AddUserControl(trans);
        }

        private void rechargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCRecharge recharge = new UCRecharge();
            AddUserControl(recharge);
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCWithdraw withdraw = new UCWithdraw();
            AddUserControl(withdraw);
        }

        private void bankSavingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBankSavings banksavings = new UCBankSavings();
            AddUserControl(banksavings);
        }

        private void employInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployeeInformation employee = new UCEmployeeInformation();
            AddUserControl(employee);
        }

        private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCAccountInformation account = new UCAccountInformation();
            AddUserControl(account);
        }
    }
}
