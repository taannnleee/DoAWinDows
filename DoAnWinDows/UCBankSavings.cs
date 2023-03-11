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
    public partial class UCBankSavings : UserControl
    {
        BankpassbookDAO bankpassbookDAO = new BankpassbookDAO();
        public UCBankSavings()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Bankpassbook bankpassbook = new Bankpassbook(txtName.Text,txtPhone.Text,txtIdentitycard.Text,txtJob.Text,txtEmail.Text,txtAddress.Text, comboBoxSendingTime.Text, dateTimeSentDate.Value, comboBoxGender.Text, int.Parse(txtDepositAmount.Text));
            bankpassbookDAO.Them(bankpassbook);
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Bankpassbook bankpassbook = new Bankpassbook(txtName.Text, txtPhone.Text, txtIdentitycard.Text, txtJob.Text, txtEmail.Text, txtAddress.Text, comboBoxSendingTime.Text, dateTimeSentDate.Value, comboBoxGender.Text, int.Parse(txtDepositAmount.Text));
            bankpassbookDAO.Sua(bankpassbook);
            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Bankpassbook bankpassbook = new Bankpassbook(txtName.Text, txtPhone.Text, txtIdentitycard.Text, txtJob.Text, txtEmail.Text, txtAddress.Text, comboBoxSendingTime.Text, dateTimeSentDate.Value, comboBoxGender.Text, int.Parse(txtDepositAmount.Text));
            bankpassbookDAO.Xoa(bankpassbook);
            LoadDanhSach();
        }

        private void UCBankSavings_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.gvQuanLy.DataSource = bankpassbookDAO.ListBankPassBook();
        }
    }
}
