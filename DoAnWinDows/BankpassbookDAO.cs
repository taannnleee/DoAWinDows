using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows
{
    public class BankpassbookDAO
    {
        DBConnection dbconnect = new DBConnection();
        public DataTable ListBankPassBook()
        {
            string sqlStr = string.Format("Select * From BankSavings");
            return dbconnect.DanhSach(sqlStr);
        }

        public void Them(Bankpassbook bankpassbook)
        {
            string sqlStr = string.Format("Insert into BankSavings(FullName,Phone,IdentityCard,Job,Email,Address_,Sendingtime,Sentdate,Gender,DepositAmount)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", bankpassbook.FullName,bankpassbook.Phone,bankpassbook.IdentityCard,bankpassbook.Job,bankpassbook.Email,bankpassbook.Address,bankpassbook.Sendingtime,bankpassbook.Sentdate,bankpassbook.Gender,bankpassbook.DepositAmount);
            dbconnect.ThucThi(sqlStr);
        }

        public void Xoa(Bankpassbook bankpassbook)
        {
            string sqlStr = string.Format("DELETE FROM BankSavings WHERE IdentityCard = '{0}'", bankpassbook.IdentityCard);
            dbconnect.ThucThi(sqlStr);
        }

        public void Sua(Bankpassbook bankpassbook)
        {
            string sqlStr = string.Format("UPDATE BankSavings SET FullName = '{0}',Phone = '{1}',Job='{2}',Email='{3}',Address_='{4}',Sendingtime='{5}',Sentdate='{6}',Gender='{7}',DepositAmount='{8}' where IdentityCard='{9}'", bankpassbook.FullName, bankpassbook.Phone, bankpassbook.Job, bankpassbook.Email, bankpassbook.Address, bankpassbook.Sendingtime, bankpassbook.Sentdate, bankpassbook.Gender, bankpassbook.DepositAmount,bankpassbook.IdentityCard);
            dbconnect.ThucThi(sqlStr);
        }
    }
}
