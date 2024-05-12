using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class Taikhoan
    {
        private string email;
        public string password;
        public Taikhoan()
        {

        }
        public Taikhoan(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
