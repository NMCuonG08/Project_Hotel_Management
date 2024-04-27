using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Data.Common;

namespace Hotel_Management
{
    internal class RoomDAO
    {
        DB_Connection BDconnection = new DB_Connection();
        public RoomDAO() {}

        public void AddRoom(Room room)
        {
            string query = "INSERT INTO RoomInformation (RoomType, RoomBed, RoomPrice, Status, RoomName, Checkin, Checkout, RoomImage, Clients, Size, HotelID) " +
               "VALUES (@Type, @Bed, @Price, @Status, @Name, @Checkin, @Checkout, @Image, @Clients, @Size, @HotelID)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Type", SqlDbType.NVarChar) { Value = room.Type },
                new SqlParameter("@Bed", SqlDbType.NVarChar) { Value = room.Bed },
                new SqlParameter("@Price", SqlDbType.NVarChar) { Value = room.Price },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = room.Status },
                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = room.Name },
                new SqlParameter("@Checkin", SqlDbType.DateTime) { Value = room.Checkin },
                new SqlParameter("@Checkout", SqlDbType.DateTime) { Value = room.Checkout },
                new SqlParameter("@Image", SqlDbType.Image) { Value = room.Image },
                new SqlParameter("@Clients", SqlDbType.NVarChar) { Value = room.Clients },
                new SqlParameter("@Size", SqlDbType.NVarChar) { Value = room.Size },
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = room.HotelID }
            };
            BDconnection.MyExecuteNonQuery(query, parameters);
        }
        public void EditRoom(Room room)
        {
            string query = "UPDATE RoomInformation SET RoomType = @Type, RoomBed = @Bed, RoomPrice = @Price, Status = @Status, RoomName = @Name, " +
                           "Checkin = @Checkin, Checkout = @Checkout, RoomImage = @Image, Clients = @Clients, Size = @Size WHERE HotelID = @HotelID AND RoomID = @RoomID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoomID", SqlDbType.Int) { Value = room.Id },
                new SqlParameter("@Type", SqlDbType.NVarChar) { Value = room.Type },
                new SqlParameter("@Bed", SqlDbType.NVarChar) { Value = room.Bed },
                new SqlParameter("@Price", SqlDbType.NVarChar) { Value = room.Price },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = room.Status },
                new SqlParameter("@Name", SqlDbType.NVarChar) { Value = room.Name },
                new SqlParameter("@Checkin", SqlDbType.DateTime) { Value = room.Checkin },
                new SqlParameter("@Checkout", SqlDbType.DateTime) { Value = room.Checkout },
                new SqlParameter("@Image", SqlDbType.Image) { Value = room.Image },
                new SqlParameter("@Clients", SqlDbType.NVarChar) { Value = room.Clients },
                new SqlParameter("@Size", SqlDbType.NVarChar) { Value = room.Size },
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = room.HotelID }
                    };
            BDconnection.MyExecuteNonQuery(query, parameters);
        }
        public void DeleteRoom(Room room)
        {
            int id = room.Id;
            string query = $"DELETE FROM RoomInformation WHERE RoomID = {id}; " +
                    $"DELETE FROM RoomConveniences WHERE RoomID = {id}; " +
                    $"DELETE FROM Bathroomconveniences WHERE RoomID = {id}";
            BDconnection.MyExecuteNonQuery(query);        
        }

        public DataTable Load(int HotelID)
        {
            string query = $"SELECT * FROM RoomInformation where HotelID = {HotelID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public Room GetRoomByID(int roomID)
        {
            Room room = null;
            string query = "SELECT * FROM RoomInformation WHERE RoomID = @RoomID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomID }
            };
            SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query, parameters);
            if (reader.Read())
            {
                room = new Room
                {
                    Id = roomID,
                    Name = reader["RoomName"].ToString(),
                    Type = reader["RoomType"].ToString(),
                    Bed = reader["RoomBed"].ToString(),
                    Price = Convert.ToInt32(reader["RoomPrice"]),
                    Status = reader["Status"].ToString(),
                    Clients = Convert.ToInt32(reader["Clients"]),
                    Size = Convert.ToDouble(reader["Size"]),
                    Image = (byte[])reader["RoomImage"],
                    Checkin = (DateTime)reader["Checkin"],
                    Checkout = (DateTime)reader["Checkout"],

                };
            }
            return room;
        }
        public int SetCount(string status, int hotelID)
        {
            string query = "SELECT COUNT(*) FROM RoomInformation WHERE HotelID = @HotelID AND Status = @Status";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HotelID", SqlDbType.Int) { Value = hotelID },
                new SqlParameter("@Status", SqlDbType.NVarChar) { Value = status }
            };
            object result = BDconnection.MyExecuteScalar(query, parameters);
            if (result != null && int.TryParse(result.ToString(), out int total))
            {
                return total;
            }
            else
            {
                return -1;
            }

        }
        public DataTable Filler(string s,int HotelID)
        {
            string query = $"SELECT * FROM RoomInformation WHERE Status = '{s}' AND HotelID = {HotelID}";
            DataTable data = BDconnection.ExecuteQueryDataTable(query);
            return data;
        }
        public SqlDataReader SetConveniences(int RoomID)
        {
            string query = $"SELECT * FROM RoomConveniences WHERE RoomID = {RoomID}";
            return BDconnection.ExecuteQueryDataReader(query, null);
        }

        public SqlDataReader SetBathroomconveniences(int RoomID)
        {
            string getBathroomConveniencesQuery = $"SELECT * FROM Bathroomconveniences WHERE RoomID = {RoomID}";
            return BDconnection.ExecuteQueryDataReader(getBathroomConveniencesQuery, null);
        }

        public void EditConveniences(int roomID, CheckedListBox checklistbox, CheckedListBox checklistbathroom)
        {
            string updateRoomConveniencesQuery = "UPDATE RoomConveniences SET ";
            for (int i = 0; i < checklistbox.Items.Count; i++)
            {
                string columnName = checklistbox.Items[i].ToString();
                bool isChecked = checklistbox.GetItemChecked(i);
                updateRoomConveniencesQuery += $"{columnName} = {(isChecked ? 1 : 0)}, ";
            }
            updateRoomConveniencesQuery = updateRoomConveniencesQuery.TrimEnd(',', ' ') + $" WHERE RoomID = {roomID}";
            BDconnection.MyExecuteNonQuery(updateRoomConveniencesQuery);
            string updateBathroomConveniencesQuery = "UPDATE Bathroomconveniences SET ";
            for (int i = 0; i < checklistbathroom.Items.Count; i++)
            {
                string columnName = checklistbathroom.Items[i].ToString();
                bool isChecked = checklistbathroom.GetItemChecked(i);
                updateBathroomConveniencesQuery += $"{columnName} = {(isChecked ? 1 : 0)}, ";
            }
            updateBathroomConveniencesQuery = updateBathroomConveniencesQuery.TrimEnd(',', ' ') + $" WHERE RoomID = {roomID}";
            BDconnection.MyExecuteNonQuery(updateBathroomConveniencesQuery);
        }

        public DataTable Search(int HotelID, string selectedType, string selectedTypeBed, DateTime checkin, DateTime checkout)
        {
            string sql = $"SELECT * FROM RoomInformation WHERE HotelID = {HotelID}";
            if (!string.IsNullOrEmpty(selectedType))
            {
                sql += $" AND RoomType = '{selectedType}'";
            }
            if (!string.IsNullOrEmpty(selectedTypeBed))
            {
                sql += $" AND RoomBed = '{selectedTypeBed}'";
            }
            if (checkin != null && checkout != null)
            {
                sql += $" AND RoomID NOT IN (SELECT RoomID FROM Booking WHERE ('{checkin}' < Checkout AND '{checkout}' > Checkin))";
            }
            DataTable data = BDconnection.ExecuteQueryDataTable(sql);
            return data;
        }

        public HashSet<string> GetUniqueOfRoom(string s)
        {
            HashSet<string> listRoom = new HashSet<string>();
           string query = $"SELECT {s} FROM RoomInformation";
           SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query,null);
            while (reader.Read())
            {
                string hotelLocation = reader[s].ToString();
                listRoom.Add(hotelLocation);
            }               
            return listRoom;
        }

        public List<String> CheckConvenience(int roomID)
        {
            List<string> convenienceNames = new List<string>();
            
                    string sqlQuery = @"
                                        SELECT COLUMN_NAME 
                                        FROM INFORMATION_SCHEMA.COLUMNS 
                                        WHERE TABLE_NAME = 'RoomConveniences' 
                                        AND DATA_TYPE = 'bit' 
                                        AND COLUMN_NAME <> 'RoomID' 
                                        AND COLUMN_NAME IN (
                                            SELECT 'Air_conditioner' FROM RoomConveniences WHERE Air_conditioner = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'TV' FROM RoomConveniences WHERE TV = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Curtains' FROM RoomConveniences WHERE Curtains = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Desk_workspace' FROM RoomConveniences WHERE Desk_workspace = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Small_kitchen' FROM RoomConveniences WHERE Small_kitchen = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Refrigerator' FROM RoomConveniences WHERE Refrigerator = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Coffee_maker' FROM RoomConveniences WHERE Coffee_maker = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Free_bottled_water' FROM RoomConveniences WHERE Free_bottled_water = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Safe_box' FROM RoomConveniences WHERE Safe_box = 1 AND RoomID = @RoomID
                                        );
                                    ";
                    SqlParameter[] parameters = new SqlParameter[]
                   {
                          new SqlParameter("@RoomID", SqlDbType.Int) { Value =roomID },
                   };
                    SqlDataReader reader = BDconnection.ExecuteQueryDataReader (sqlQuery,parameters);
                    while (reader.Read())
                    {
                        string columnName = reader["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }
                    reader.Close();
                    string sqlQuery2 = @"
                                        SELECT COLUMN_NAME 
                                        FROM INFORMATION_SCHEMA.COLUMNS 
                                        WHERE TABLE_NAME = 'Bathroomconveniences' 
                                        AND DATA_TYPE = 'bit' 
                                        AND COLUMN_NAME <> 'RoomID' 
                                        AND COLUMN_NAME IN (
                                            SELECT 'Private_bathroom' FROM Bathroomconveniences WHERE Private_bathroom = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Personal_hygiene_kit' FROM Bathroomconveniences WHERE Personal_hygiene_kit = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Hair_dryer' FROM Bathroomconveniences WHERE Hair_dryer = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Standing_shower' FROM Bathroomconveniences WHERE Standing_shower = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Large_mirror' FROM Bathroomconveniences WHERE Large_mirror = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Bluetooth_speaker' FROM Bathroomconveniences WHERE Bluetooth_speaker = 1 AND RoomID = @RoomID
                                            UNION
                                            SELECT 'Ventilation_system' FROM Bathroomconveniences WHERE Ventilation_system = 1 AND RoomID = @RoomID                                          
                                        );
                                    ";
            SqlParameter[] parameters2 = new SqlParameter[]
           {
                 new SqlParameter("@RoomID", SqlDbType.Int) { Value = roomID },
           };
                    SqlDataReader reader2 = BDconnection.ExecuteQueryDataReader(sqlQuery2, parameters2);
            while (reader2.Read())
                    {
                        string columnName = reader2["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }
                    reader2.Close();
           
            return convenienceNames;
        }
    }
}
