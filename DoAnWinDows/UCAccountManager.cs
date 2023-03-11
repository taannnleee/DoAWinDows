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
    public partial class UCAccountManager : UserControl
    {
        AccountDao accountDao = new AccountDao();
        public UCAccountManager()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Account user = new Account(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtJob.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(),txtBalance.Text);
            accountDao.Them(user);
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Account user = new Account(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtJob.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), txtBalance.Text);
            accountDao.Sua(user);
            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Account user = new Account(txtName.Text, txtPhone.Text, txtPassWord.Text, txtIdentitycard.Text, txtJob.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), txtBalance.Text);
            accountDao.Xoa(user);
            LoadDanhSach();
        }

        private void UCAccountManager_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.gvQuanLy.DataSource = accountDao.DanhSachQuanLy();
        }
    }
}
