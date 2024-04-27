using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace Hotel_Management
{
    internal class HotelInformationDAO
    {
        DB_Connection BDconnection = new DB_Connection();
        public HotelInformationDAO() { }

        public HotelInformation GETHotelInformation(int adminID)
        {
            HotelInformation hotelInformation = null;
            string query = "select * from HotelInformation where AdminID =@adminID ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@adminID", SqlDbType.Int) { Value = adminID }
            };
            SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query, parameters);
            if (reader.Read())
            {
                hotelInformation = new HotelInformation
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
            return hotelInformation;
        }

        public HotelInformation GetHotelInformationByID(int id)
        {
            HotelInformation hotel = new HotelInformation();
            string query = "Select * from HotelInformation where HotelID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@ID", SqlDbType.Int) { Value = id }
           };
            SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query, parameters);
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
            return hotel;
        }
        public SqlDataReader SetConveniences(int HotelID)
        {
            string query = $"SELECT * FROM Hotel_conveniences WHERE HotelID = {HotelID}";
            return BDconnection.ExecuteQueryDataReader(query, null);
        }
      
        public DataTable LoadHotel()
        {
            string query = "SELECT * FROM HotelInformation";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }

        public void EditHotelConvenience(int HotelID, CheckedListBox checkedListBox)
        {
            string updateRoomConveniencesQuery = "UPDATE Hotel_conveniences SET ";
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                string columnName = checkedListBox.Items[i].ToString();
                bool isChecked = checkedListBox.GetItemChecked(i);
                updateRoomConveniencesQuery += $"[{columnName}] = {(isChecked ? 1 : 0)}, ";
            }
            updateRoomConveniencesQuery = updateRoomConveniencesQuery.TrimEnd(',', ' ') + $" WHERE HotelID = {HotelID}";
            BDconnection.MyExecuteNonQuery(updateRoomConveniencesQuery);
        }

        public void UpdateHotel( HotelInformation hotelInfo)
        {
            string query = "UPDATE HotelInformation SET HotelName = @HotelName, City = @City, Street = @Street, FeedBack = @FeedBack, Price = @Price, HotelImage = @HotelImage, email = @Email, zipcode = @Zipcode, FloorsNumber = @FloorsNumber, Capacity = @Capacity, PhoneNumber = @PhoneNumber, Country = @Country, Descriptions = @Descriptions WHERE HotelID = @HotelID";
           
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = hotelInfo.Id },
                new SqlParameter("@HotelName", SqlDbType.NVarChar) { Value = hotelInfo.Name },
                new SqlParameter("@City", SqlDbType.NVarChar) { Value = hotelInfo.City },
                new SqlParameter("@Street", SqlDbType.NVarChar) { Value = hotelInfo.Street },
                new SqlParameter("@FeedBack", SqlDbType.Float) { Value = hotelInfo.Score },
                new SqlParameter("@Price", SqlDbType.Float) { Value = hotelInfo.Price },
                new SqlParameter("@HotelImage", SqlDbType.VarBinary) { Value = hotelInfo.HotelImage },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = hotelInfo.Email },
                new SqlParameter("@Zipcode", SqlDbType.NVarChar) { Value = hotelInfo.Zipcode },
                new SqlParameter("@FloorsNumber", SqlDbType.Int) { Value = hotelInfo.Floors },
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = hotelInfo.Capacity },
                new SqlParameter("@PhoneNumber", SqlDbType.NVarChar) { Value = hotelInfo.PhoneNumber },
                new SqlParameter("@Country", SqlDbType.NVarChar) { Value = hotelInfo.Country },
                new SqlParameter("@Descriptions", SqlDbType.NVarChar) { Value = hotelInfo.Description }
            };

            BDconnection.MyExecuteNonQuery(query, parameters);
        }
        public bool CheckHotelExist(int adminID)
        {
            string query = $"SELECT COUNT(*) FROM HotelInformation WHERE AdminID = {adminID}";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && Convert.ToInt32(result) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateHotel(HotelInformation hotelInfo, int adminID)
        {
            string query = "Insert into HotelInformation values (@HotelName, @City, @Street, @FeedBack, @Price, @HotelImage, @email, @zipcode, @FloorsNumber, @Capacity, @PhoneNumber, @Country, @AdminID, @Descriptions) ";
            SqlParameter[] parameters = new SqlParameter[]
           {
                new SqlParameter("@AdminID", SqlDbType.Int) { Value = adminID},
                new SqlParameter("@HotelName", SqlDbType.NVarChar) { Value = hotelInfo.Name },
                new SqlParameter("@City", SqlDbType.NVarChar) { Value = hotelInfo.City },
                new SqlParameter("@Street", SqlDbType.NVarChar) { Value = hotelInfo.Street },
                new SqlParameter("@FeedBack", SqlDbType.Float) { Value = hotelInfo.Score },
                new SqlParameter("@Price", SqlDbType.Float) { Value = hotelInfo.Price },
                new SqlParameter("@HotelImage", SqlDbType.VarBinary) { Value = hotelInfo.HotelImage },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = hotelInfo.Email },
                new SqlParameter("@Zipcode", SqlDbType.NVarChar) { Value = hotelInfo.Zipcode },
                new SqlParameter("@FloorsNumber", SqlDbType.Int) { Value = hotelInfo.Floors },
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = hotelInfo.Capacity },
                new SqlParameter("@PhoneNumber", SqlDbType.NVarChar) { Value = hotelInfo.PhoneNumber },
                new SqlParameter("@Country", SqlDbType.NVarChar) { Value = hotelInfo.Country },
                new SqlParameter("@Descriptions", SqlDbType.NVarChar) { Value = hotelInfo.Description }
           };

            BDconnection.MyExecuteNonQuery(query, parameters);
        }

        public void CreateHotelConvenience(CheckedListBox checkedListBox)
        {
            int maxHotelID;
            string getMaxHotelIDQuery = "SELECT MAX(HotelID) FROM HotelInformation";
            object result = BDconnection.MyExecuteScalar(getMaxHotelIDQuery,null);
            maxHotelID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            int newHotelID = maxHotelID;
            string addHotelConvenienceQuery = "INSERT INTO Hotel_conveniences (HotelID) VALUES (@HotelID)";
            SqlParameter[] parameters = new SqlParameter[]
          {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = newHotelID},
          };
            BDconnection.MyExecuteNonQuery(addHotelConvenienceQuery, parameters);
            foreach (object itemChecked in checkedListBox.CheckedItems)
            {
                string updateQuery = "UPDATE Hotel_conveniences SET ";
                string itemName = itemChecked.ToString();
                updateQuery += $"[{itemName}] = 1 WHERE HotelID = @HotelID";
                SqlParameter[] parameters2 = new SqlParameter[]
         {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = newHotelID},
         };
                BDconnection.MyExecuteNonQuery(updateQuery, parameters2);

            }
        }

        public int SetCount(HotelInformation hotelInfo)
        {
            string query = $"Select Count(*) from RoomInformation where HotelID = {hotelInfo.Id} ";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return -1;
            }
        }
        public DataTable SetFeedBack(int HotelID)
        {
            string query = $"SELECT * FROM Evaluate where HotelID = {HotelID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public int SetAVG(int HotelID)
        {
            string query = $"Select AVG(Rate) from Evaluate where HotelID = {HotelID}";
            object result = BDconnection.MyExecuteScalar(query, null);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return -1;
            }
        }

        public DataTable FindingHotel( string selectedLocation, CheckedListBox checkedListBox_convenience)
        {
            string query = @"SELECT HI.* 
                           FROM HotelInformation HI 
                           JOIN Hotel_conveniences HC ON HI.HotelID = HC.HotelID 
                           WHERE 1=1";
            if (!string.IsNullOrEmpty(selectedLocation))
            {
                query += $" AND  HI.City = '{selectedLocation}'";
            }
            foreach (object item in checkedListBox_convenience.CheckedItems)
            {
                string checkedItem = item.ToString();
                if (!string.IsNullOrEmpty(checkedItem))
                {
                    query += $" AND HC.[{checkedItem}] = 1";
                }
            }
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable OrderPice( string type, string s)
        {
            string query = $"SELECT * FROM HotelInformation ORDER BY {type} {s}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public DataTable OrderValue(string type, int max, int min)
        {
            string query = String.Format($"SELECT * FROM HotelInformation WHERE {type} <= {0} AND {type} >= {1}", max, min);
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public SqlDataReader CheckConveniences(int HotelID)
        {
            string query = @"
                                        SELECT COLUMN_NAME 
                                        FROM INFORMATION_SCHEMA.COLUMNS 
                                        WHERE TABLE_NAME = 'Hotel_conveniences' 
                                        AND DATA_TYPE = 'bit' 
                                        AND COLUMN_NAME <> 'HotelID' 
                                        AND COLUMN_NAME IN (
                                            SELECT 'Breakfast' FROM Hotel_conveniences WHERE Breakfast = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Free_WiFi' FROM Hotel_conveniences WHERE Free_WiFi = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT '247_Room_Service' FROM Hotel_conveniences WHERE [247_Room_Service] = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Daily_Housekeeping' FROM Hotel_conveniences WHERE Daily_Housekeeping = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Restaurant_and_Bar' FROM Hotel_conveniences WHERE Restaurant_and_Bar = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Swimming_Pool_and_Spa' FROM Hotel_conveniences WHERE Swimming_Pool_and_Spa = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Laundry_Service' FROM Hotel_conveniences WHERE Laundry_Service = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Parking_area' FROM Hotel_conveniences WHERE Parking_area = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Gym' FROM Hotel_conveniences WHERE Gym = 1 AND HotelID = @HotelID
                                        );
                                    ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = HotelID }
            };
            return BDconnection.ExecuteQueryDataReader(query, parameters);
        }

        public HashSet<string> GetUniqueHotelLocation()
        {
            HashSet<string> listHotel = new HashSet<string>();
            string query = "SELECT City FROM HotelInformation";
            SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query, null);
            while (reader.Read())
            {
                string hotelLocation = reader["City"].ToString();
                listHotel.Add(hotelLocation);
            }
            return listHotel;
        }
        public int SetRating( int hotelID)
        {
            string query = "Select AVG(Rate) from Evaluate where HotelID = @hotelID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = hotelID }, 
            };
            object result = BDconnection.MyExecuteScalar(query, parameters);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return 0;
            }
        }

    }
}
