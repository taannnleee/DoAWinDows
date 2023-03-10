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
        AccountDao account = new AccountDao();
        public UCAccountManager()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void UCAccountManager_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.gvQuanLy.DataSource = account.DanhSachQuanLy();
        }
    }
}
