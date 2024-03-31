using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public  class Payinfo
    {
        private int id;
        private DateTime addDate;
        private string paymentMethod;
        private double amount;
        private int bookingID;
        public Payinfo() { }
        public Payinfo( DateTime addDate, string paymentMethod, double amount, int bookingID)
        {          
            this.AddDate = addDate;
            this.PaymentMethod = paymentMethod;
            this.Amount = amount;
            this.BookingID = bookingID;
        }

        public int Id { get => id; set => id = value; }
        public DateTime AddDate { get => addDate; set => addDate = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public double Amount { get => amount; set => amount = value; }
        public int BookingID { get => bookingID; set => bookingID = value; }
    }
}
