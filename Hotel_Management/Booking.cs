using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class Booking
    {
        public Booking() { }
        private int id;
        private string username;
        private DateTime checkin;
        private DateTime checkout;
        private DateTime bookingdate;
        private string paymentstatus;
        private string bookingstatus;
        private int userID;
        private int roomID;
        private int hotelID;
        private double price;
        private bool isCheckOut;
        public Booking( string username, DateTime checkin, DateTime checkout, DateTime bookingdate, string paymentstatus, string bookingstatus, int userID, int roomID, int hotelID, double price, bool isCheckOut)
        {
            this.Username = username;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Bookingdate = bookingdate;
            this.Paymentstatus = paymentstatus;
            this.Bookingstatus = bookingstatus;
            this.UserID = userID;
            this.RoomID = roomID;
            this.HotelID = hotelID;
            this.Price = price;
            this.IsCheckOut = isCheckOut;
        }
        public Booking(string username, DateTime checkin, DateTime checkout, DateTime bookingdate, string paymentstatus, string bookingstatus, int userID, int roomID, int hotelID, double price)
        {
            this.Username = username;
            this.Checkin = checkin;
            this.Checkout = checkout;
            this.Bookingdate = bookingdate;
            this.Paymentstatus = paymentstatus;
            this.Bookingstatus = bookingstatus;
            this.UserID = userID;
            this.RoomID = roomID;
            this.HotelID = hotelID;
            this.Price = price;
           
        }
        public Booking(int id,DateTime checkout, double price)
        {
            this.id = id;
            this.Checkout = checkout;
            this.Price = price;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public DateTime Checkin { get => checkin; set => checkin = value; }
        public DateTime Checkout { get => checkout; set => checkout = value; }
        public DateTime Bookingdate { get => bookingdate; set => bookingdate = value; }
        public string Paymentstatus { get => paymentstatus; set => paymentstatus = value; }
        public string Bookingstatus { get => bookingstatus; set => bookingstatus = value; }
        public int UserID { get => userID; set => userID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int HotelID { get => hotelID; set => hotelID = value; }
        public double Price { get => price; set => price = value; }
        public bool IsCheckOut { get => isCheckOut; set => isCheckOut = value; }
    }
}
