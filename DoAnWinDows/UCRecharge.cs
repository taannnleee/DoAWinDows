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
    public partial class UCRecharge : UserControl
    {
        AccountDao accountdao= new AccountDao();
        public UCRecharge()
        {
            InitializeComponent();
        }

        private void btnShowInfor_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Identitycard=txtAccountNumber.Text;
            LoadInformation(account);
        }
        private void LoadInformation(Account account)
        {
            this.gvInforAccount.DataSource = accountdao.ShowInfomation(account);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            Account account=new Account();
            account.Identitycard = txtAccountNumber.Text;
            account.Balance = ((int)gvInforAccount.Rows[0].Cells[9].Value + int.Parse(txtAmountOfMoney.Text)).ToString();
            accountdao.Recharge(account);
            LoadInformation(account);
        }
    }
}
