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
    public partial class Book_room : Form
    {
        //  public int HotelID;
        public int UserID;
        public int RoomID;
        private int HotelID;
        public Book_room(int userID, int roomID, int hotelID)
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
            /*this.UserID = User.Id;
            this.UserID = Room.Id;*/
            
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

            // Check if HotelInformation object is not null
            if (HotelInformation != null)
            {
                lb_hotelname.Text = HotelInformation.Name ?? string.Empty;

                // Check if HotelImage is not null
                if (HotelInformation.HotelImage != null)
                {
                    byte[] image = HotelInformation.HotelImage;
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        picturebox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }

            // Check if Room object is not null
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
                try
                {
                    using (SqlConnection connection = Connection.GetSqlConnection())
                    {
                        connection.Open();
                        string query = "Insert into Booking values (@CustomerName, @Checkin,@CheckOut, @BookingDate,@PaymentStatus,@BookingStatus,@UserID,@RoomID,@HotelID,@Price)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@CustomerName", txb_nameuser.Text));
                        command.Parameters.Add(new SqlParameter("Checkin", timep_checkin.Value));
                        command.Parameters.Add(new SqlParameter("Checkout", timep_checkout.Value));
                        command.Parameters.Add(new SqlParameter("BookingDate", DateTime.Now));
                        command.Parameters.Add(new SqlParameter("@PaymentStatus", "pending"));
                        command.Parameters.Add(new SqlParameter("@BookingStatus", "pending"));
                        command.Parameters.Add(new SqlParameter("@UserID", UserID));
                        command.Parameters.Add(new SqlParameter("RoomID", RoomID));
                        command.Parameters.Add(new SqlParameter("HotelID", HotelID));
                        command.Parameters.Add(new SqlParameter("Price", price));
                        command.ExecuteNonQuery();
                        string sql = "Update UserRegister set Useremail = @email,[National] = @national,Genders = @gender,Idcardnumber = @idcard,[Address] = @address,PhoneNumber = @phone where ID = @UserID";
                        SqlCommand cmd = new SqlCommand(sql, connection);
                        cmd.Parameters.Add(new SqlParameter("@email", txb_useremail.Text));
                        cmd.Parameters.Add(new SqlParameter("@national", txb_national.Text));
                        cmd.Parameters.Add(new SqlParameter("@gender", txb_gender.Text));
                        cmd.Parameters.Add(new SqlParameter("@idcard", txb_idcardnumber.Text));
                        cmd.Parameters.Add(new SqlParameter("@address", txb_address.Text));
                        cmd.Parameters.Add(new SqlParameter("@phone", txb_phonenumber.Text));
                        cmd.Parameters.Add(new SqlParameter("@UserID", UserID));
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBooking.Show("You Booking Sucessful!", "Notification");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
