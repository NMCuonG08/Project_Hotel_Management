using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Management
{
    public partial class Sampleupdatecheckout : Form
    {
        public Sampleupdatecheckout()
        {
            InitializeComponent();
        }
        public int id = 0;
        public void btn_save_Click(object sender, EventArgs e)
        {
            string query = "";
            if (id == 0)
            {
                query = "INSERT INTO Booking (CustomerName, CheckIn, CheckOut) VALUES (@CustomerName, @Checkin, @Checkout)";
            }
            else
            {
                query = "UPDATE Booking SET CustomerName = @CustomerName,  CheckIn = @Checkin, Checkout = @Checkout WHERE ID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@CustomerName", txb_name.Text);        
            ht.Add("@Checkin", datecheckin.Value);
            ht.Add("@Checkout", datecheckout.Value);

            if (ClassCheckout.SQL(query, ht) > 0)
            {
                MessageBox.Show("Lưu thành công");
                id = 0;
                txb_name.Text = "";
                txb_phone.Text = "";
               txb_roonno.Text = "";
                txb_roomtype.Text = "";
                datecheckin.Value = DateTime.Now;
                datecheckout.Value = DateTime.Now;
               txb_name.Focus();
            }
        }

        public void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
