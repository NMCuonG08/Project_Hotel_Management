using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Account
    {

        private int _id;
        private string _useremail;
        private string _password;
        private string _national;
        private string _gender;
        private string _idcardnumber;
        private string _address;
        private string _phonenumber;
        private DateTime _birthday;
        private string _role;

        public Account()
        {
        }

        public Account(int id, string useremail, string password, string national, string gender, string idcardnumber, string address, string phonenumber, DateTime birthday, string role)
        {
            _id = id;
            _useremail = useremail;
            _password = password;
            _national = national;
            _gender = gender;
            _idcardnumber = idcardnumber;
            _address = address;
            _phonenumber = phonenumber;
            _birthday = birthday;
            _role = role;
        }
        public Account(int id, string useremail, string national, string gender, string idcardnumber, string address, string phonenumber)
        {
            _id = id;
            _useremail = useremail;
            _national = national;
            _gender = gender;
            _idcardnumber = idcardnumber;
            _address = address;
            _phonenumber = phonenumber;
        }

        public int Id { get => _id; set => _id = value; }
        public string Useremail { get => _useremail; set => _useremail = value; }
        public string Password { get => _password; set => _password = value; }
        public string National { get => _national; set => _national = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Idcardnumber { get => _idcardnumber; set => _idcardnumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public DateTime Birthday { get => _birthday; set => _birthday = value; }
        public string Role { get => _role; set => _role = value; }
    }
}
