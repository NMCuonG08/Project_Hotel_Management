﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FSignIn : Form
    {
        public FSignIn()
        {
            InitializeComponent();
        }
        public bool checkacout(string ac) // check mat khau
        {
            return Regex.IsMatch(ac, "[a - zA - Z0 - 9]{ 6,24}$");
        }
        public bool Checkemail(string em)
        {
            return Regex.IsMatch(em, @"^[a - zA - Z0 - 9_.]{3,20}@gmail.com(.vn|)$");
        }
        
        Modify modify = new Modify();
        private void btn_complete_Click_1(object sender, EventArgs e)
        {
            string Useremail = txb_sigemail.Text;
            string Password=txb_sigpassword.Text;
            string National = txb_signational.Text;
            string Genders = txb_siggender.Text;
            string Idcardnumber = txb_sigIdcard.Text;
            string Address = txb_sigaddress.Text;
            string Phonenumber = txb_sigphone.Text;
            DateTime dateTime = datetime_birthday.Value;
            string role = cbx_role.Text; 
            if (checkacout(Password))
            {
                message.Show("Please enter a password 6-24 characters long, with alphanumeric characters, uppercase and lowercase letters!");
                return;
            }
            if(Checkemail(Useremail))
            {
                message.Show("Please enter the correct email format!");
                return;
            }
            if (modify.Taikhoans("select*from UserRegister where Useremail='" + Useremail + "'").Count != 0)
            {
                message.Show("This email is already registered, please register another email!");
                return;
            }
            if (Useremail.Trim() == "" || Password.Trim() == "" || National.Trim() == "" || Genders.Trim() == "" || Idcardnumber.Trim() == "" || Address.Trim() == "" || Phonenumber.Trim() == "" || role.Trim() == "" )
            {
                message.Show("Please enter your information register!");

            }
            else
            {
                string query = "Insert into UserRegister values('" + Useremail + "','" + Password + "','" + National + "','" + Genders + "','" + Idcardnumber + "','" + Address + "','" + Phonenumber + "', '" + dateTime + "', '" + role + "' )";
                modify.command(query);
                message.Show("Registration is successful,", "Announcement");
                
                    this.Close();
                    FLogin fLogin = new FLogin();
                    fLogin.Show();
                
            }
        }
       
        private void FSignIn_Load(object sender, EventArgs e)
        {

        }
        private void datetime_birthday_ValueChanged(object sender, EventArgs e)
        {

        }
       
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Show();

        }

        private void txb_sigemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_sigpassword.Focus();
            }
        }

        private void txb_sigpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_signational.Focus();
            }
        }

        private void txb_signational_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_siggender.Focus();
            }
        }

        private void txb_siggender_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txb_sigIdcard.Focus();
            }
        }

        private void txb_sigIdcard_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                txb_sigaddress.Focus();
            }
        }

        private void txb_sigaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                txb_sigphone.Focus();
            }
        }
    }
}
