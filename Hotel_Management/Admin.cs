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
    public partial class Admin : Form, IHotelIDConsumer
    {
        public int HotelID { get; set; }
        public int AdminID { get; set; }
        private Account Adm = new Account();
        public Admin(Account admin)
        {
            InitializeComponent();
        //    this.WindowState = FormWindowState.Maximized;
            this.HotelID = FindHotelID(admin.Id);
            Adm = admin;
            this.AdminID = Adm.Id;
            
        }

        public int FindHotelID(int adminID)
        {
            int hotelID = -1; 

            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string sql = "SELECT HotelID FROM HotelInformation WHERE AdminID = @AdminID";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            hotelID = Convert.ToInt32(reader["HotelID"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hotelID;
        }

        FHotelInformation hotelInformation;
        FRoomInformation roomInformation;
        FCustomerRegistration fCustomerRegistration;
        Fcheckout fcheckout;
        FAddRoom addRoom;
        FListRoom listRoom;
        FBooking booking;
        public void ShowForm(Form form)
        {
            if (form is IHotelIDConsumer)
            {
                ((IHotelIDConsumer)form).HotelID = HotelID;
            }
            form.MdiParent = this;
            form.Show();
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listRoom = new FListRoom(HotelID);
            listRoom.FormClosed += ListRoom_FormClosed;
            ShowForm(listRoom);
        }
        private void ListRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            listRoom = null;
        }

        private void main_transaction_Tick(object sender, EventArgs e)
        {
            if (mainTransaction == true)
            {
                panel_main.Width -= 10;
                if (panel_main.Width == panel_main.MinimumSize.Width)
                {
                    mainTransaction = false;
                    main_transaction.Stop();
                }
            }
            else
            {
                panel_main.Width += 10;
                if (panel_main.Width == panel_main.MaximumSize.Width)
                {
                    mainTransaction = true;
                    main_transaction.Stop();
                }
            }
        }

        #region
        private void AddRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            addRoom = null;
        }
        bool mainTransaction;
        private void btn_menu_Click(object sender, EventArgs e)
        {
            main_transaction.Start();
        }    
        private void btn_room_Click(object sender, EventArgs e)
        {
            Main_Load(sender, e);
            btn_hotel.BackColor = Color.FromArgb(0, 64, 64);
            btn_hotel.ForeColor = Color.White;
            btn_room.BackColor = Color.DarkGray;
            btn_room.ForeColor = Color.Black;
            btn_booking.BackColor = Color.FromArgb(0, 64, 64);
            btn_booking.ForeColor = Color.White;
            btn_checkout.BackColor = Color.FromArgb(0, 64, 64);
            btn_checkout.ForeColor = Color.White;
            btn_feedback.ForeColor = Color.White;
            btn_feedback.BackColor = Color.FromArgb(0, 64, 64);
        }
        private void btn_hotel_Click(object sender, EventArgs e)
        {
            if (hotelInformation == null)
            {
                hotelInformation = new FHotelInformation(AdminID);
                hotelInformation.FormClosed += HotelInformation_FormClosed;
                ShowForm(hotelInformation);
            }
            else
            {
                hotelInformation.Activate();
            }

            btn_hotel.BackColor = Color.DarkGray;
            btn_hotel.ForeColor = Color.Black;
            btn_room.BackColor = Color.FromArgb(0, 64, 64);
            btn_room.ForeColor = Color.White;
            btn_booking.BackColor = Color.FromArgb(0, 64, 64);
            btn_booking.ForeColor = Color.White;
            btn_checkout.BackColor = Color.FromArgb(0, 64, 64); ;
            btn_checkout.ForeColor = Color.White;
            btn_feedback.ForeColor = Color.White;
            btn_feedback.BackColor = Color.FromArgb(0, 64, 64);

        }
        private void HotelInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelInformation = null;
        }
        private void btn_booking_Click(object sender, EventArgs e)
        {
            booking = new FBooking(HotelID);
            booking.FormClosed += Booking_FormClosed;
            ShowForm(booking);
            btn_hotel.BackColor = Color.FromArgb(0, 64, 64);
            btn_hotel.ForeColor = Color.White;
            btn_room.BackColor = Color.FromArgb(0, 64, 64);
            btn_room.ForeColor = Color.White;
            btn_booking.BackColor = Color.DarkGray;
            btn_booking.ForeColor = Color.Black;
            btn_checkout.BackColor = Color.FromArgb(0, 64, 64); ;
            btn_checkout.ForeColor = Color.White;
            btn_feedback.ForeColor = Color.White;
            btn_feedback.BackColor = Color.FromArgb(0, 64, 64);
        }
        private void Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            booking = null;
        }
       private void btn_guest_Click(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            fcheckout = new Fcheckout(HotelID);
            fcheckout.FormClosed += Fcheckout_FormClosed;
            ShowForm(fcheckout);
            btn_hotel.BackColor = Color.FromArgb(0, 64, 64);
            btn_hotel.ForeColor = Color.White;
            btn_room.BackColor = Color.FromArgb(0, 64, 64);
            btn_room.ForeColor = Color.White;
            btn_booking.BackColor = Color.FromArgb(0, 64, 64);
            btn_booking.ForeColor = Color.White;
            btn_checkout.BackColor = Color.DarkGray;
            btn_checkout.ForeColor = Color.Black;
            btn_feedback.ForeColor = Color.White;
            btn_feedback.BackColor = Color.FromArgb(0, 64, 64);
        }
        private void Fcheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            fcheckout = null;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {

        }
        FFeedBack fFeedBack; 
        private void btn_feedback_Click(object sender, EventArgs e)
        {
            if (fFeedBack == null)
            {
                fFeedBack = new FFeedBack(HotelID);
                fFeedBack.FormClosed += FFeedBack_FormClosed;
                ShowForm(fFeedBack);
            }
            else
            {
                fFeedBack.Activate();
            }
            btn_hotel.BackColor = Color.FromArgb(0, 64, 64);
            btn_hotel.ForeColor = Color.White;
            btn_room.BackColor = Color.FromArgb(0, 64, 64);
            btn_room.ForeColor = Color.White;
            btn_booking.BackColor = Color.FromArgb(0, 64, 64);
            btn_booking.ForeColor = Color.White;
            btn_feedback.BackColor = Color.DarkGray;
            btn_feedback.ForeColor = Color.Black;
            btn_checkout.ForeColor = Color.White;
            btn_checkout.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void FFeedBack_FormClosed(object sender, FormClosedEventArgs e)
        {
            fFeedBack = null;
        }


        #endregion

        // change form
        #region




    }
    #endregion

}
