﻿using System;
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
    public partial class FExtendBooking : Form
    {
        Room Room { get; set; }
        Account User { get; set; }
        int HotelID { get; set; }
        int BookingID { get; set; }
        double priceroom;
        double oldprice;
        DateTime old_checkout;
        BookingDAO bookingDAO = new BookingDAO();
        public FExtendBooking(Room room, Account user, int hotelID, int bookingID)
        {
            this.Room = room;
            this.User = user;
            this.HotelID = hotelID;
            this.BookingID = bookingID;
            InitializeComponent();
            Setlb();
        }

        private void Setlb()
        {
            Booking booking = Instance.GetBookingByID(BookingID);
            txb_guest.Text = User.Useremail;
            txb_phoneNumber.Text = User.Phonenumber;
            txb_roomno.Text = Room.Id.ToString();
            txb_roomtype.Text = Room.Type.ToString();
            datetime_checkin.Value = booking.Checkin;
            datetime_checkout.Value = booking.Checkout;
            datetime_checkout.MinDate = datetime_checkout.Value.AddDays(1);
            oldprice = booking.Price;
            old_checkout = booking.Checkout;
            priceroom = Room.Price;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
                    double price = (datetime_checkout.Value.Day - old_checkout.Day)*priceroom + oldprice;
                    Booking booking = new Booking(BookingID,datetime_checkout.Value, price);
                    bookingDAO.SaveExtendBooking(booking);
                    MessageBox.Show("Extend Booking Successful!", "Notification", MessageBoxButtons.OK);
                    this.Close();
        }
    }
}
