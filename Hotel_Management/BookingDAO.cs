using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal class BookingDAO
    {
        DB_Connection BDconnection = new DB_Connection();
        public BookingDAO() { }
        public DataTable Load(int HotelID)
        {
            string query = $"SELECT * FROM Booking where HotelID = {HotelID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable LoadBookingByUserID(int UserID)
        {
            string query = $"Select * from Booking where UserID = {UserID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable Finding(int hotelID,ComboBox combox, string condition)
        {
            string query = $"SELECT * FROM Booking where HotelID = {hotelID} AND {condition} = '{combox.Text}'";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable Seacrch(int hotelID, Guna2TextBox textBox)
        {
            string query = $"SELECT * FROM Booking WHERE HotelID = {hotelID} AND CustomerName LIKE '%{textBox.Text}%'";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable Setpayment(int bookingID)
        {
            string query = $"SELECT * FROM Payment where BookingID = {bookingID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public int SetTotalPayment(int BookingID)
        {
            string query = $" SELECT ISNULL(SUM(Amount), 0) FROM Payment where BookingID = {BookingID}";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return 0;
            }
        }
        public int SetPendingPayment(int BookingID)
        {
            string query = $" SELECT ISNULL(Price, 0) FROM Booking where ID = {BookingID}";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return 0;
            }
        }
        public void UpdateBooking(int bookingID, string value, string status)
        {
            string query = $"Update Booking set {status} = '{value}' where ID ={bookingID} ";
            BDconnection.MyExecuteNonQuery(query, null);
        }
      
        public void UpdateRoom(int roomID, string status)
        {
            string query = $"Update RoomInformation set [Status] = '{status}' where RoomID = {roomID}";
            BDconnection.MyExecuteNonQuery(query, null);
        }
        public int SetInvoceNumber()
        {
            string query = "Select MAX(ID) from Payment ";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return 0;
            }
        }
        public void SavePayment(Payinfo payinfo)
        {
            string query = "Insert into Payment values (@AddDate, @PaymentMethod, @Amount, @BookingID)  ";
            SqlParameter[] parameters = new SqlParameter[]
          {
                new SqlParameter("@AddDate", SqlDbType.DateTime) { Value = payinfo.AddDate },
                new SqlParameter("@PaymentMethod", SqlDbType.NVarChar) { Value = payinfo.PaymentMethod },
                new SqlParameter("@Amount", SqlDbType.Float) { Value = payinfo.Amount },
                new SqlParameter("@BookingID", SqlDbType.Int) { Value = payinfo.BookingID }, 
           };
            BDconnection.MyExecuteNonQuery(query, parameters);
        }
        public DataTable GetCheckOutInformation(int hotelID)
        {
            string query = $"select * from Booking where HotelID = {hotelID} AND BookingStatus = 'Success'";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public void SaveExtendBooking(Booking booking)
        {
            string query = "Update Booking set CheckOut = @checkout, Price = @price where ID= @BookingID";
            SqlParameter[] parameters = new SqlParameter[]
          {
                new SqlParameter("@checkout", SqlDbType.DateTime) { Value = booking.Checkout },
                new SqlParameter("@price", SqlDbType.Float) { Value = booking.Price },
                new SqlParameter("@BookingID", SqlDbType.Int) { Value = booking.Id },
           };
            BDconnection.MyExecuteNonQuery(query, parameters);
        }
       public void BookRoom(Booking booking, Account user)
        {    
            string query = "Insert into Booking values (@CustomerName, @Checkin,@CheckOut, @BookingDate,@PaymentStatus,@BookingStatus,@UserID,@RoomID,@HotelID,@Price)";
            SqlParameter[] parameters = new SqlParameter[]
          {
                new SqlParameter("@CustomerName", SqlDbType.NChar) { Value = booking.Username },
                new SqlParameter("@Checkin", SqlDbType.DateTime) { Value = booking.Checkin },
                new SqlParameter("@CheckOut", SqlDbType.DateTime) { Value = booking.Checkout },
                 new SqlParameter("@BookingDate", SqlDbType.DateTime) { Value = booking.Bookingdate },
                new SqlParameter("@PaymentStatus", SqlDbType.NChar) { Value = booking.Paymentstatus },
                new SqlParameter("@BookingStatus", SqlDbType.NChar) { Value = booking.Bookingstatus },
                 new SqlParameter("@UserID", SqlDbType.Int) { Value = booking.UserID },
                new SqlParameter("@RoomID", SqlDbType.Int) { Value = booking.RoomID },
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = booking.HotelID },
                new SqlParameter("@Price", SqlDbType.Float) { Value = booking.Price },
           };
            BDconnection.MyExecuteNonQuery(query, parameters);
            string sql = "Update UserRegister set Useremail = @email,[National] = @national,Genders = @gender,Idcardnumber = @idcard,[Address] = @address,PhoneNumber = @phone where ID = @UserID";
            SqlParameter[] parameters2 = new SqlParameter[]
        {
                new SqlParameter("@email", SqlDbType.NChar) { Value = user.Useremail },
                new SqlParameter("@national", SqlDbType.NChar) { Value = user.National },
                new SqlParameter("@gender", SqlDbType.NVarChar) { Value = user.Gender },
                 new SqlParameter("@idcard", SqlDbType.NVarChar) { Value = user.Idcardnumber },
                new SqlParameter("@address", SqlDbType.NChar) { Value = user.Address },
                new SqlParameter("@phone", SqlDbType.NChar) { Value = user.Phonenumber },
                 new SqlParameter("@UserID", SqlDbType.Int) { Value = user.Id },
         };
            BDconnection.MyExecuteNonQuery(sql, parameters2) ;

        }

        public void CancelBooking(int bookingID)
        {
            string query = $"Delete from Booking where ID = {bookingID}";
            BDconnection.MyExecuteNonQuery(query, null);
        }
    }
}
