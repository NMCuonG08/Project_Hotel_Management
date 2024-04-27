using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FBook_room : Form
    {
        public int UserID;
        public int RoomID;
        private int HotelID;
        BookingDAO bookingDAO = new BookingDAO();
        public FBook_room(int userID, int roomID, int hotelID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.RoomID = roomID;
            this.HotelID = hotelID;
        }
        double price;
        public void SetTime(DateTime checkin, DateTime checkout, Room Room)
        {
            timep_checkin.Value = checkin;
            timep_checkout.Value = checkout;
            TimeSpan timeSpan = checkout - checkin;
            int amount = Math.Abs(timeSpan.Days);
            price = ((Room.Price)*amount);
        }
        public void SetData(Room Room, Account User, HotelInformation HotelInformation)
        {       
            if (User != null)
            {
                txb_national.Text = User.National ?? string.Empty;
                txb_gender.Text = User.Gender ?? string.Empty;
                txb_address.Text = User.Address ?? string.Empty;
                txb_idcardnumber.Text = User.Idcardnumber ?? string.Empty;
                txb_phonenumber.Text = User.Phonenumber ?? string.Empty;
                txb_useremail.Text = User.Useremail ?? string.Empty;
                lb_price.Text = price.ToString();
            }
            if (HotelInformation != null)
            {
                lb_hotelname.Text = HotelInformation.Name ?? string.Empty;
                if (HotelInformation.HotelImage != null)
                {
                    byte[] image = HotelInformation.HotelImage;
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        picturebox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            if (Room != null)
            {
                lb_roomtype.Text = Room.Type ?? string.Empty;
                lb_bed.Text = Room.Bed ?? string.Empty;
                lb_roomsize.Text = Room.Size.ToString() + " m2";
                lb_clients.Text = Room.Clients.ToString() + " clients";
                lb_price.Text = price.ToString() + " $";
            }
        }

        public bool Check()
        {
            if (string.IsNullOrEmpty(txb_nameuser.Text)) { return false; }

            return true;
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            if (Check())
            {
               Booking booking = new Booking(txb_nameuser.Text, timep_checkin.Value, timep_checkout.Value, DateTime.Now, "pending", "pending", UserID,RoomID,HotelID,price);
                Account user = new Account(UserID, txb_useremail.Text, txb_national.Text, txb_gender.Text, txb_idcardnumber.Text, txb_address.Text, txb_phonenumber.Text);         
              bookingDAO.BookRoom(booking, user);
                        MessageBooking.Show("You Booking Sucessful!", "Notification");
                this.Close();
            }
            else
            {
                MessageBooking.Show("Fail!");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_room_Load(object sender, EventArgs e)
        {

        }

       
    }
}
