using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public static class Instance
    {
        public static int AID { get; set; }
        public static int HID { get; set; }
        public static int BID { get; set; }
        public static bool Isloggedout = false;
        public static Room GetRoomByID(int id)
        {
            Room room = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from RoomInformation where RoomID = @RoomID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@RoomID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            Id = id,
                            Name = reader["RoomName"].ToString(),
                            Type = reader["RoomType"].ToString(),
                            Bed = reader["RoomBed"].ToString(),
                            // Kiểm tra trước khi chuyển đổi và xử lý giá trị DBNull
                            Price = reader["RoomPrice"] != DBNull.Value ? Convert.ToInt32(reader["RoomPrice"]) : 0,
                            Status = reader["Status"].ToString(),
                            Clients = reader["Clients"] != DBNull.Value ? Convert.ToInt32(reader["Clients"]) : 0,
                            Size = reader["Size"] != DBNull.Value ? Convert.ToDouble(reader["Size"]) : 0.0,
                            // Kiểm tra và xử lý giá trị DBNull khi đọc dữ liệu hình ảnh
                            Image = reader["RoomImage"] != DBNull.Value ? (byte[])reader["RoomImage"] : null
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return room;
        }
        public static HotelInformation GetHotelInformationByID(int id)
        {
            HotelInformation hotel = new HotelInformation();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from HotelInformation where HotelID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        hotel = new HotelInformation
                        {
                            Id = id,
                            Name = reader["HotelName"].ToString(),
                            City = reader["City"].ToString(),
                            Street = reader["Street"].ToString(),
                            Email = reader["email"].ToString(),
                            Zipcode = reader["zipcode"].ToString(),
                            PhoneNumber = reader["Phonenumber"].ToString(),
                            Country = reader["Country"].ToString(),
                            Description = reader["Descriptions"].ToString(),
                            // Kiểm tra trước khi chuyển đổi và xử lý giá trị DBNull
                            Score = reader["Feedback"] != DBNull.Value ? Convert.ToInt32(reader["Feedback"]) : 0,
                            Price = reader["Price"] != DBNull.Value ? Convert.ToDouble(reader["Price"]) : 0.0,
                            Floors = reader["FloorsNumber"] != DBNull.Value ? Convert.ToInt32(reader["FloorsNumber"]) : 0,
                            Capacity = reader["Capacity"] != DBNull.Value ? Convert.ToInt32(reader["Capacity"]) : 0,
                            // Kiểm tra và xử lý giá trị DBNull khi đọc dữ liệu hình ảnh
                            HotelImage = reader["HotelImage"] != DBNull.Value ? (byte[])reader["HotelImage"] : null
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hotel;
        }

        public static Account GetUserByID(int id)
        {
            Account user = new Account();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from UserRegister where ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        user = new Account
                        {
                            Id = id,
                            Useremail = reader["Useremail"].ToString(),
                            Password = reader["Password"].ToString(),
                            National = reader["National"].ToString(),
                            Idcardnumber = reader["Idcardnumber"].ToString(),
                            Gender = reader["Genders"].ToString(),
                            Address = reader["Address"].ToString(),
                            Phonenumber = reader["Phonenumber"].ToString(),
                            // Kiểm tra trước khi chuyển đổi và xử lý giá trị DBNull
                            Birthday = reader["Birthday"] != DBNull.Value ? (DateTime)reader["Birthday"] : DateTime.MinValue,
                            Role = "user"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return user;
        }
        public static Booking GetBookingByID(int id)
        {
            Booking booking = new Booking();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from Booking where ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        booking = new Booking
                        {
                            Id = id,
                            Username = reader["CustomerName"].ToString(),
                            Checkin = reader["CheckIn"] != DBNull.Value ? (DateTime)reader["CheckIn"] : DateTime.MinValue,
                            Checkout = reader["CheckOut"] != DBNull.Value ? (DateTime)reader["CheckOut"] : DateTime.MinValue,
                            Bookingdate = reader["BookingDate"] != DBNull.Value ? (DateTime)reader["BookingDate"] : DateTime.MinValue,
                            Paymentstatus = reader["PaymentStatus"].ToString(),
                            Bookingstatus = reader["BookingStatus"].ToString(),
                            UserID = (Int32)reader["UserID"],
                            RoomID = (Int32)reader["RoomID"],
                            HotelID = (Int32)reader["HotelID"],
                            Price = (Double)reader["Price"]
                            //  Night = reader["Night"].ToString(),
                        };

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return booking;
        }
        public static HotelInformation ReadHotel()
        {
            int adminID = AID;
            HotelInformation hotel = null;
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                string query = "select * from HotelInformation where AdminID =@adminID ";
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@adminID", adminID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hotel = new HotelInformation
                                {
                                    Id = reader.IsDBNull(reader.GetOrdinal("HotelID")) ? 0 : (Int32)reader["HotelID"],
                                    Name = reader.IsDBNull(reader.GetOrdinal("HotelName")) ? "" : (String)reader["HotelName"],
                                    PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader["PhoneNumber"].ToString(),
                                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader["email"].ToString(),
                                    Country = reader.IsDBNull(reader.GetOrdinal("Country")) ? "" : reader["Country"].ToString(),
                                    City = reader.IsDBNull(reader.GetOrdinal("City")) ? "" : reader["City"].ToString(),
                                    Street = reader.IsDBNull(reader.GetOrdinal("Street")) ? "" : reader["Street"].ToString(),
                                    Capacity = reader.IsDBNull(reader.GetOrdinal("Capacity")) ? 0 : (Int32)reader["Capacity"],
                                    Floors = reader.IsDBNull(reader.GetOrdinal("FloorsNumber")) ? 0 : (Int32)reader["FloorsNumber"],
                                    Zipcode = reader.IsDBNull(reader.GetOrdinal("zipcode")) ? "" : reader["zipcode"].ToString(),
                                    Description = reader.IsDBNull(reader.GetOrdinal("Descriptions")) ? "" : reader["Descriptions"].ToString(),
                                    Score = reader.IsDBNull(reader.GetOrdinal("Feedback")) ? 0.0 : (Double)reader["Feedback"],
                                    Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.0 : (Double)reader["Price"],
                                    HotelImage = (byte[])reader["HotelImage"]
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return hotel;
        }

        public static Payinfo GetBookingInforByID(int id)
        {

            Payinfo payment = new Payinfo();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from Booking where ID = @ID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        payment = new Payinfo
                        {
                            Id = id,                           
                            AddDate = reader["CheckIn"] != DBNull.Value ? (DateTime)reader["CheckIn"] : DateTime.MinValue, 
                            PaymentMethod = reader["PaymentStatus"].ToString(),
                            Amount = (double)reader["UserID"],
                            BookingID = (Int32)reader["RoomID"],
                        };

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return payment;
        }

        public static Account user { get; set; }
        public static String Getname(int id)
        {
            string s = "";
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
            {
                conn.Open();
                string query = "Select * from UserFullName where UID = @id";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                    s = reader["Name"].ToString();
            }
            return s;
        }


    }
}
