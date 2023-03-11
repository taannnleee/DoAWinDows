using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows
{
    public class Account
    {
        private string name;
        private string username;
        private string password;
        private string identitycard;
        private string job;
        private string phone;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private string gender;
        private string balance;


        public string Name { get { return name; } set { name = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set {password = value; } }
        public string Identitycard { get { return identitycard; } set { identitycard = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }
        public DateTime Dateofbirth { get { return dateofbirth; } set { dateofbirth = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Job { get { return job; } set { job = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Balance { get => balance; set => balance = value; }

        public Account() { }
        public Account(string name, string phone, string password, string identitycard, string job, string email, string address, DateTime dateofbirth, string gender, string balance)
        {
            Name = name;
            Password = password;
            Identitycard = identitycard;
            Job = job;
            Phone = phone;
            Email = email;
            Address = address;
            Dateofbirth = dateofbirth;
            Gender = gender;
            Balance = balance;
        }
    }
}
