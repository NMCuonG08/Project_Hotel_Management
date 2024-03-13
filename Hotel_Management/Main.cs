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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

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

            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (listRoom == null)
            {
                listRoom = new FListRoom();
                listRoom.FormClosed += ListRoom_FormClosed;
               
                ShowForm(listRoom);
            }
            else
            {
                listRoom.Activate();
            }
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

        private void AddNewRoom()
        {

            if (addRoom == null)
            {
                addRoom = new FAddRoom();
                addRoom.FormClosed += AddRoom_FormClosed;


                ShowForm(addRoom);
            }
            else
            {
                addRoom.Activate();
            }


        }

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
        }

        private void btn_hotel_Click(object sender, EventArgs e)
        {
            if (hotelInformation == null)
            {
                hotelInformation = new FHotelInformation();
                hotelInformation.FormClosed += HotelInformation_FormClosed;
                ShowForm(hotelInformation);
            }
            else
            {
                hotelInformation.Activate();
            }
        }

        private void HotelInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            hotelInformation = null;
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            if (booking == null)
            {
                booking = new FBooking();
                booking.FormClosed += Booking_FormClosed;
                ShowForm(booking);
            }
            else
            {
                booking.Activate();
            }
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
            if (fcheckout == null)
            {
                fcheckout = new Fcheckout();
                fcheckout.FormClosed += Fcheckout_FormClosed;
                ShowForm(fcheckout);
            }
            else
            {
                fcheckout.Activate();
            }
        }

        private void Fcheckout_FormClosed(object sender, FormClosedEventArgs e)
        {
            fcheckout = null;
        }


        #endregion

        // change form
        #region




    }
    #endregion

}
