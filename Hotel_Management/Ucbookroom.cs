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
    public partial class Ucbookroom : UserControl
    {
       

        public Ucbookroom()
        {
            InitializeComponent();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string CustomerName = txb_nameuser.Text;
            string UserID = txb_iduser.Text;
            string HotelID = txb_idhotel.Text;
            string PaymentStatus = cbx_payment.Text;
            DateTime BookingDate = time_bookingday.Value;
            DateTime CheckIn = timep_checkin.Value;
            DateTime CheckOut = timep_checkout.Value;

            if (string.IsNullOrWhiteSpace(CustomerName) || string.IsNullOrWhiteSpace(UserID) || string.IsNullOrWhiteSpace(HotelID))
            {
                MessageBox.Show("Please enter your information!");
                return;
            }

            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();

                    // Tạo câu lệnh SQL với tham số
                    string bookings = "INSERT INTO Booking (CustomerName, CheckIn, CheckOut, BookingDate, PaymentStatus, UserID, HotelID) " +
                                      "VALUES (@CustomerName, @CheckIn, @CheckOut, @BookingDate, @PaymentStatus, @UserID,@HotelID)";

                    using (SqlCommand command = new SqlCommand(bookings, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@CustomerName", CustomerName);
                        command.Parameters.AddWithValue("@CheckIn", CheckIn);
                        command.Parameters.AddWithValue("@CheckOut", CheckOut);
                        command.Parameters.AddWithValue("@BookingDate", BookingDate);
                        command.Parameters.AddWithValue("@PaymentStatus", PaymentStatus);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@HotelID", HotelID);

                        // Thực thi câu lệnh SQL
                        command.ExecuteNonQuery();

                        MessageBox.Show("Booking successful!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Ucbookroom_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void cbx_payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
