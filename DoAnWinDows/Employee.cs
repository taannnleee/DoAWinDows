using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows
{
    public class Employee
    {
        private string id;
        private string fullname;
        private string phone;
        private string identitycard;
        private string email;
        private string address;
        private DateTime dateofbirth;
        private string gender;
        private string salary;

        public string Id { get { return id; }set { id = value; } }
        public string FullName { get { return fullname; } set { fullname = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string IdentityCard { get { return identitycard; } set { identitycard = value; } }
        public string Email { get { return email; }set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public DateTime DateOfBirth { get { return dateofbirth; } set { dateofbirth = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Salary { get { return salary; } set { salary = value; } }

        public Employee() { }

        public Employee(string id, string fullname, string phone, string identitycard,string email, string address, DateTime dateofbirth, string gender, string salary)
        {
            this.id = id;
            this.fullname = fullname;
            this.phone = phone;
            this.identitycard = identitycard;
            this.email = email;
            this.address = address;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.salary = salary;
        }
    }
}
