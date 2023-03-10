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
    }
}
