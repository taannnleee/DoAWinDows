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
    public partial class UCEmployeeManager : UserControl
    {
        EmployeeDao employeeDao = new EmployeeDao();
        public UCEmployeeManager()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtID.Text,txtName.Text,txtPhone.Text,txtIdentitycard.Text,txtEmail.Text,txtAddress.Text,dateTimeDateOfBirth.Value,comboBoxGender.SelectedItem.ToString(), txtSalary.Text);
            employeeDao.Them(employee);
            LoadDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtID.Text, txtName.Text, txtPhone.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), txtSalary.Text);
            employeeDao.Xoa(employee);
            LoadDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtID.Text, txtName.Text, txtPhone.Text, txtIdentitycard.Text, txtEmail.Text, txtAddress.Text, dateTimeDateOfBirth.Value, comboBoxGender.SelectedItem.ToString(), txtSalary.Text);
            employeeDao.Sua(employee);
            LoadDanhSach();
        }
        private void LoadDanhSach()
        {
            this.gvEmployee.DataSource = employeeDao.DanhSachQuanLy();
        }

        private void UCEmployeeManager_Load(object sender, EventArgs e)
        {
            LoadDanhSach();
        }
    }
}
