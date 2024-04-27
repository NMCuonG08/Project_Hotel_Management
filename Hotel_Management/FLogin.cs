﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Linq;


namespace Hotel_Management
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            txb_email.Focus();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btn_complete_Click_1(object sender, EventArgs e)
        {
            string UserEmail = txb_email.Text;
            string passwords = txb_password.Text;
            if (UserEmail.Trim() == "")
            {
                message.Show("Please enter your account name!", "Announcement");

            }
            else if (passwords.Trim() == "")
            {
                message.Show("Please enter your password!", "Announcement");

            }
            else
            {
               CheckLogin(UserEmail, passwords);
            }

        }


        private Account SelectUser(string userEmail, string Password)
        {
            Account user = new Account();

            using (SqlConnection sqlConnection = DB_Connection.GetSqlConnection())
            {
                string query = "SELECT * FROM UserRegister WHERE Useremail = @Useremail AND Password = @Password";

                try
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Useremail", userEmail);
                        sqlCommand.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc thông tin từ SqlDataReader và tạo đối tượng User
                                user = new Account
                                {                                 
                                    Id = (Int32)reader["ID"],
                                    Useremail = reader["Useremail"].ToString(),
                                    National = reader["National"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Phonenumber = reader["Phonenumber"].ToString(),
                                    Gender = reader["Genders"].ToString(),
                                    Birthday = (DateTime)(DBNull.Value.Equals(reader["BirthDay"]) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("BirthDay"))),
                                    Idcardnumber = reader["Idcardnumber"].ToString(),
                                    Password = reader["Password"].ToString(),
                                    Role = reader["Role"].ToString(),

                                };
                                Instance.user = user;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    message.Show(e.Message);
                }

                return user;
            }
        }

        private void CheckLogin(string email, string password)
        {
            string query = "SELECT [password] from UserRegister where Useremail = @Email";
            using (SqlConnection connection = DB_Connection.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Email", email);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storePassword = reader["password"].ToString();
                            if (!string.IsNullOrEmpty(storePassword))
                            {
                                Account account = SelectUser(email, password);
                                if (account != null )
                                {
                                   if (account.Role == "user")
                                    {
                                        Instance.Isloggedout = false;
                                        FFindingRoom fFinding = new FFindingRoom(account);
                                        fFinding.ShowDialog();
                                    }
                                   else if (account.Role == "admin")
                                    {
                                        //   this.Hide();
                                        DB_Connection.fad = new Admin(account);
                                        DB_Connection.admin = account;
                                        DB_Connection.fad.ShowDialog();
                                    }
                                }
                            }
                            else
                            {
                                message.Show("Incorrect password!");
                            }
                        }
                        else
                        {
                            message.Show("User not found!");
                        }
                    }
                }
            }
        }




        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FSignIn fSignIn = new FSignIn();
            fSignIn.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uc_FG.Visible = true;
            uc_FG.BringToFront();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void txb_email_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_hipe_Click(object sender, EventArgs e)
        {
           if( txb_password.PasswordChar == '●')
            {
                btn_eye.BringToFront();
                txb_password.PasswordChar = '\0';
                btn_hipe.Visible = false;
            }
           
        }
        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txb_password.PasswordChar == '\0')
            {
                btn_hipe.BringToFront();
                txb_password.PasswordChar = '●';
                btn_eye.Visible = false;
            }
        }

        private void txb_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_password.Focus();
            }
        }

        private void txb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Enter))
            {
                btn_complete.Focus();
            }
        }

        private void uc_FG_Load(object sender, EventArgs e)
        {

        }
    }
}
