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
    public partial class Ucbookroom : UserControl
    {
       

        public Ucbookroom()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string CustomerName = txb_nameuser.Text;
            string UserID = txb_iduser.Text;
            string HotelID = txb_idhotel.Text;
            DateTime CheckIn = timep_checkin.Value;
            DateTime CheckOut = timep_checkout.Value;

            if(CustomerName.Trim()==""|| UserID.Trim() == ""|| HotelID.Trim() == "")
            {
                MessageBox.Show("Please enter your Information!");
            }
            else 
            {
                string query = "Insert into Booking values()";
                modify.command(query);
                MessageBox.Show("Book!");
            }
            }
        private void Ucbookroom_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
