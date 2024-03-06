using Guna.UI2.WinForms;
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
    public partial class FCustomerRegistration : Form
    {
        public FCustomerRegistration()
        {
            InitializeComponent();
            txb_name.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txb_name_Enter(object sender, EventArgs e)
        {
            
        }

        private void EventKeyDownFocus(Guna2TextBox textBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox.Focus();
            }
        }

        private void txb_name_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_phone, e);
        }


        private void txb_phone_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_nationality, e);
        }

        private void txb_nationality_KeyDown(object sender, KeyEventArgs e)
        {

            //EventKeyDownFocus(txb_gender, e);
            
        }

        private void txb_gender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                datepk_db.Focus();
            }
        }

        private void datepk_db_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_id,e);
        }

        private void txb_address_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                datepkCheckin.Focus();
            }
        }

        private void txb_id_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_address, e);
        }

        private void datepkCheckin_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_bed, e);
        }

        private void txb_bed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_roomType.Focus();
            }
        }

        private void txb_roomType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_roomNo.Focus();
            }
        }

        private void txb_roomNo_KeyDown(object sender, KeyEventArgs e)
        {
            EventKeyDownFocus(txb_price, e);
        }

        

        private void txb_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_complete.Focus();
            }
        }

        private void btn_complete_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txb_gender_KeyDown_1(object sender, KeyEventArgs e)
        {

        }
    }
}
