using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows
{
    public class EmployeeDao
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select * From EmployeeInformation");
            return dbconnect.DanhSach(sqlStr);
        }

        public void Them(Employee employee)
        {
            string sqlStr = string.Format("Insert into EmployeeInformation(ID,FullName,Phone,IdentityCard,Email,Address_,DateOfBirth,Gender,Salary)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",employee.Id, employee.FullName, employee.Phone, employee.IdentityCard, employee.Email, employee.Address, employee.DateOfBirth, employee.Gender,employee.Salary);
            dbconnect.ThucThi(sqlStr);
        }

        public void Xoa(Employee employee)
        {
            string sqlStr = string.Format("DELETE FROM EmployeeInformation WHERE IdentityCard = '{0}'", employee.IdentityCard);
            dbconnect.ThucThi(sqlStr);
        }

        public void Sua(Employee employee)
        {
            string sqlStr = string.Format("UPDATE EmployeeInformation SET ID = '{0}',FullName = '{1}',Phone ='{2}',Email='{3}',Address_='{4}',DateOfBirth='{5}',Gender='{6}',Salary='{7}' where IdentityCard='{8}'", employee.Id,employee.FullName,employee.Phone,employee.Email,employee.Address,employee.DateOfBirth,employee.Gender,employee.Salary,employee.IdentityCard);
            dbconnect.ThucThi(sqlStr);
        }
    }
}
