using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class uc_FGpass : UserControl
    {
        public uc_FGpass()
        {
            InitializeComponent();
            label1.Text = "";
        }
        Modify modify = new Modify();
        private void uc_FGpass_Load(object sender, EventArgs e)
        {

        }

        private void txb_getpass_Click(object sender, EventArgs e)
        {
            string Useremail = txb_email.Text.ToString();
         

            if (Useremail.Trim()=="")
            {
                MessageBox.Show("Please enter your information User !", "announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                string query = "select*from UserRegister where UserEmail='" + Useremail + "'";
                if(modify.Taikhoans(query).Count!=0)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "Password: " + modify.Taikhoans(query)[0].Password;
                }
                else 
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "This email isn't already registered!";
                }
            }

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
