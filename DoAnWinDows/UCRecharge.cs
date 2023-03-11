﻿using System;
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
            LoadDanhSach(account);
        }
        private void LoadDanhSach(Account account)
        {
            this.gvInforAccount.DataSource = accountdao.ShowInfomation(account);
        }
    }
}
