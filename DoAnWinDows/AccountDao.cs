using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows
{
    public class AccountDao
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable DanhSachQuanLy()
        {
            string sqlStr = string.Format("Select * From UserAccount");
            return dbconnect.DanhSach(sqlStr);
        }

        public void Them(Account account)
        {
            string sqlStr = string.Format("Insert into UserAccount(FullName,Phone,Pass,IdentityCard,Job,Email,Address_,DateOfBirth,Gender,Balance)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", account.Name, account.Phone, account.Password, account.Identitycard, account.Job, account.Email, account.Address, account.Dateofbirth, account.Gender,account.Balance);
            dbconnect.ThucThi(sqlStr);
        }

        public void Xoa(Account account)
        {
            string sqlStr = string.Format("DELETE FROM UserAccount WHERE IdentityCard = '{0}'", account.Identitycard);
            dbconnect.ThucThi(sqlStr);
        }

        public void Sua(Account account)
        {
            string sqlStr = string.Format("UPDATE UserAccount SET FullName = '{0}',Phone = '{1}',Pass ='{2}',Job='{3}',Email='{4}',Address_='{5}',DateOfBirth='{6}',Gender='{7}',Balance='{8}' where IdentityCard='{9}'", account.Name, account.Phone, account.Password, account.Job, account.Email, account.Address,account.Dateofbirth, account.Gender,account.Balance, account.Identitycard);
            dbconnect.ThucThi(sqlStr);
        }
        public DataTable ShowInfomation(Account account)
        {
            string sqlStr = string.Format("Select * From UserAccount WHERE IdentityCard = '{0}'", account.Identitycard);
            return dbconnect.DanhSach(sqlStr);
        }
    }
}
