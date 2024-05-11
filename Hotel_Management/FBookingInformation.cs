using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FBookingInformation : Form
    {
        Room Room { get; set; }
        Account User { get; set; }
        int HotelID { get; set; }
        int BookingID { get; set; }
        BookingDAO bookingDAO = new BookingDAO();
        public FBookingInformation()
        {
            InitializeComponent();
            LoadPayment();
        }
        public FBookingInformation(Room room, Account user, int hotelID, int bookingID )    
        {
            this.Room = room;
            this.User = user;
            this.HotelID = hotelID;
            this.BookingID = bookingID;
            InitializeComponent();
            ShowDetailsPanel();
            LoadPayment();
            Setlb();
        }

        public void LoadPayment()
        {
            dgv.DataSource = bookingDAO.Setpayment(BookingID);
                    dgv.Columns["BookingID"].Visible = false;
                    double total = bookingDAO.SetTotalPayment(BookingID);
                    lbtpaid.Text = total.ToString();
                    double pending = bookingDAO.SetPendingPayment(BookingID);
                    double value = pending - total;
            if (total == 0)
            {
                lb_pendingpay.Text = value.ToString();
                combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[0];
            }
            else if (value > 0)
            {
                lb_pendingpay.Text = value.ToString();
                combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[3];
            }
            else
            {
                lb_pendingpay.Text = "0";
                Btn_addpayment.Enabled = false;
                combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[1];
            }
        }
        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FAddPayment fAddPayment = new FAddPayment(BookingID, this, this.HotelID);
            fAddPayment.SetData();
            fAddPayment.ShowDialog();
           
        }
        void Setlb()
        {
            Booking booking = Instance.GetBookingByID(BookingID);
            HotelInformation h = Instance.GetHotelInformationByID(HotelID);
            lbName.Text = h.Name.ToString();
            lbCity.Text = h.City.ToString(); 
            lbCountry.Text = h.Country.ToString(); ;
            lbPhone.Text = h.PhoneNumber.ToString();
            lbEmail.Text = h.Email.ToString(); 
            lbgname.Text = booking.Username.ToString(); 
            lbCityy.Text = User.National.ToString();
            lbGCountry.Text = User.National.ToString(); 
            lbGEmail.Text = User.Useremail.ToString(); 
            lbGPhone.Text = User.Phonenumber.ToString();
            lb_bookingdate.Text = booking.Bookingdate.ToString();
            lbbn.Text = booking.Id.ToString();
            lbcin.Text = booking.Checkin.ToString();
            lbcout.Text = booking.Checkout.ToString();
            lbps.Text = booking.Paymentstatus.ToString();
            lbbs.Text = booking.Bookingstatus.ToString();
            lbg.Text = "1";
            lbn.Text = "1";
            lbtp.Text = booking.Price.ToString() + " $";           
            dgv2.Rows[0].Cells[0].Value = Room.Id;
            dgv2.Rows[0].Cells[1].Value = Room.Type.ToString();
            dgv2.Rows[0].Cells[2].Value = Room.Bed;
            combx_Bookingstatus.Text = booking.Bookingstatus.ToString();
            combx_paymentstatus.Text = booking.Paymentstatus.ToString();
        }

        private void FBookingInformation_Load(object sender, EventArgs e)
        {
            Setlb();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowDetailsPanel()
        {
            panel_details.Visible = true;
            panel_payment.Visible = false;
            panel_room.Visible = false;

            btn_details.FillColor = Color.White;
            btn_details.ForeColor = Color.Teal;
            btn_payment.FillColor = Color.Teal;
            btn_payment.ForeColor = Color.White;
            btn_room.FillColor = Color.Teal;
            btn_room.ForeColor = Color.White;
        }
        private void btn_details_Click(object sender, EventArgs e)
        {
            ShowDetailsPanel();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            panel_details.Visible = false;
            panel_payment.Visible = true;
            panel_room.Visible = false;
            btn_payment.FillColor = Color.White;
            btn_payment.ForeColor = Color.Teal;
            btn_details.FillColor = Color.Teal;
            btn_details.ForeColor = Color.White;
            btn_room.FillColor = Color.Teal;
            btn_room.ForeColor = Color.White;
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            panel_details.Visible = false;
            panel_payment.Visible = false;
            panel_room.Visible = true;

            btn_room.FillColor = Color.White;
            btn_room.ForeColor = Color.Teal;
            btn_details.FillColor = Color.Teal;
            btn_details.ForeColor = Color.White;
            btn_payment.FillColor = Color.Teal;
            btn_payment.ForeColor = Color.White;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combx_paymentstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingDAO.UpdateBooking(BookingID, combx_paymentstatus.Text, "PaymentStatus");
            if (combx_paymentstatus.Text == "Success")
            {
                btn_checkout.Enabled = true;
            }
            else
            {
                btn_checkout.Enabled=false;
            }
        }

        private void combx_Bookingstatus_SelectedIndexChanged(object sender, EventArgs e)
        {         
             bookingDAO.UpdateBooking(BookingID, combx_Bookingstatus.Text, "BookingStatus");
             if (combx_Bookingstatus.Text == "Success")
            {
                bookingDAO.UpdateRoom(Room.Id, "Occupied");
            }
             else 
            {
                bookingDAO.UpdateRoom(Room.Id, "Empty");
            }
        }
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            bookingDAO.UpdateBooking(BookingID, "pening", "BookingStatus", true);
            bookingDAO.UpdateRoom(Room.Id, "Empty");
            MessageBox.Show("Checkout thành công", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
