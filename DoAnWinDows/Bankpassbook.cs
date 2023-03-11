using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAnWinDows
{
    public class Bankpassbook
    {
        private string fullName;
        private string phone;
        private string identityCard;
        private string job;
        private string email;
        private string address;
        private string sendingtime;
        private DateTime sentdate;
        private string gender;
        private int depositAmount;

        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string Job { get => job; set => job = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Sendingtime { get => sendingtime; set => sendingtime = value; }
        public DateTime Sentdate { get => sentdate; set => sentdate = value; }
        public string Gender { get => gender; set => gender = value; }
        public int DepositAmount { get => depositAmount; set => depositAmount = value; }
        public Bankpassbook() { }
        public Bankpassbook(string fullName, string phone, string identityCard, string job, string email, string address, string sendingtime, DateTime sentdate, string gender, int depositAmount)
        {
            FullName = fullName;
            Phone = phone;
            IdentityCard = identityCard;
            Job = job;
            Email = email;
            Address = address;
            Sendingtime = sendingtime;
            Sentdate = sentdate;
            Gender = gender;
            DepositAmount = depositAmount;
            FullName = fullName;
            Phone = phone;
            IdentityCard = identityCard;
            Job = job;
            Email = email;
            Address = address;
            Sendingtime = sendingtime;
            Sentdate = sentdate;
            Gender = gender;
            DepositAmount = depositAmount;
        }
    }
}
