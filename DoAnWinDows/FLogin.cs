namespace DoAnWinDows
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rbtnQuanLy.Checked == true)
            {
                FManager quanly = new FManager();
                quanly.Show();
            }
            else
            {
                //FKhach khach = new FKhach();
                //khach.Show();
            }
        }
    }
}