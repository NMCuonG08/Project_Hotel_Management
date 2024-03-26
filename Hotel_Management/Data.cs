using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public static class Data
    {
        public static HotelInformation currentHotelData;
        public static int adminid;
        public static BookingData bData;
        public static string invoiceNum;
        public static string pMethod;
        public static string amount;
        public static DateTime dt;
        public static HotelInformation ReadData(int adminID)
        {
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
    }
}
