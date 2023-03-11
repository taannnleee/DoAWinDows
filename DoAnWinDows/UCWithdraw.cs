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
    public partial class UCWithdraw : UserControl
    {
        public UCWithdraw()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (gvInformation.Rows.Count == 0) //khong tim thay khach hang, thong tin khong hop le hoac de trong
            {
                errorIdentityCard.SetError(txtIdentityCard, "You must enter valid information");
            }
            else
            {
                errorIdentityCard.SetError(txtIdentityCard, null);
                MessageBox.Show("Withdraw successfully", "Notification");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //tim kiem thong tin nguoi dung
        }

        //rut tien
    }
}
