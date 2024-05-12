using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FAddPayment : Form
    {
        private int BookingID;
        private int HotelID;
        BookingDAO bookingDAO = new BookingDAO();
        public FAddPayment(int bookingID, FBookingInformation fBooking, int hotelID)
        {
            InitializeComponent();
            this.BookingID = bookingID;
            FBookingInformation = fBooking;
            this.HotelID = hotelID;
        }

        public void SetData()
        {
            txb_invoce_number.Text = bookingDAO.SetInvoceNumber().ToString();
            txb_add_date.Text = DateTime.Now.ToString();
            txb_amount.Text = "0";
            combx_pymethod.SelectedItem = combx_pymethod.Items[2];
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save()
        {
            Payinfo payinfo = new Payinfo
            {
                AddDate = DateTime.Now,
                PaymentMethod = combx_pymethod.Text,
                Amount = Convert.ToInt32(txb_amount.Text),
                BookingID = BookingID,
                HotelID = HotelID
            };
            bookingDAO.SavePayment(payinfo);
        }       
           
        private FBookingInformation FBookingInformation  ;
        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void FAddPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            FBookingInformation.LoadPayment();
        }

        private void txb_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
