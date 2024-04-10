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
    public partial class FChoiceRoom : Form
    {
        public int HotelID ;
        public int UserID;
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        
        public FChoiceRoom(int hotelID, int userID)
        {
            InitializeComponent();
            this.HotelID = hotelID;
            this.UserID = userID;
            LoadForm(HotelID);
            datetime_checkin.MinDate =  DateTime.Today.AddDays(1);
            datetime_checkout.MinDate = datetime_checkin.Value.AddDays(1);
        }
        void LoadForm(int HotelID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM RoomInformation where HotelID = @HotelID ";
                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@HotelID", HotelID);
                dataAdapter.Fill(data);
                gvRoom.DataSource = data;
                createItem(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            HashSet<string> uniqueRoomType = GetUniqueRoomType();
            cbx_typeroom.DataSource = new BindingSource(uniqueRoomType, null);
            HashSet<string> uniqueRoomBed = GetUniqueRoomBed();
            cbx_typebed.DataSource = new BindingSource(uniqueRoomBed, null);
        }

        private void createItem(DataTable data)
        {
            int count = data.Rows.Count;
            if (count > 0)
            {
                UCRoomInformation[] ls = new UCRoomInformation[count];
                for (int i = 0; i < count; i++)
                {
                    if (data.Rows[i]["Status"].ToString() != "Empty")
                    {
                        continue;
                    }

                    ls[i] = new UCRoomInformation();
                    object roomID = data.Rows[i]["RoomID"];
                    if (roomID != DBNull.Value)
                    {
                        ls[i].Id = Convert.ToInt32(roomID);
                    }
                    object roomType = data.Rows[i]["RoomType"];
                    if (roomType != DBNull.Value)
                    {
                        ls[i].Roomtype = roomType.ToString();
                    }
                    object roomBed = data.Rows[i]["RoomBed"];
                    if (roomBed != DBNull.Value)
                    {
                        ls[i].Roombed = roomBed.ToString();
                    }
                    object price = data.Rows[i]["RoomPrice"];
                    if (price != DBNull.Value)
                    {
                        ls[i].Price = Convert.ToDouble(price);
                    }
                    object hotelSize = data.Rows[i]["Size"];
                    if (hotelSize != DBNull.Value)
                    {
                        ls[i].HotelSize = Convert.ToDouble(hotelSize);
                    }
                    byte[] image = (byte[])data.Rows[i]["RoomImage"];
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].RoomImage = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    object capacity = data.Rows[i]["Clients"];
                    if (capacity != null)
                    {
                        ls[i].Capacity = capacity.ToString();
                    }
                    List<String> con = CheckConvenience(ls[i].Id);
                    foreach (String s in con)
                    {
                        ls[i].SetPanelVisibility(s);
                    }
                    ls[i].ItemBooking += FChoiceRoom_ItemBooking;
                    flowLayoutPanel1.Controls.Add(ls[i]);
                    
                }
            }
        }

        private List<String> CheckConvenience(int roomID)
        {
            List<string> convenienceNames = new List<string>();
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
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

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@RoomID", roomID);

                    SqlDataReader reader = command.ExecuteReader();
                   

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

                    SqlCommand command2 = new SqlCommand(sqlQuery2, connection);
                    command2.Parameters.AddWithValue("@RoomID", roomID);

                    SqlDataReader reader2 = command2.ExecuteReader();
                    

                    while (reader2.Read())
                    {
                        string columnName = reader2["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }

                    reader2.Close();

                   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return convenienceNames;
        }
        private void FChoiceRoom_ItemBooking(object sender, EventArgs e)
        {
            UCRoomInformation clickbooking = sender as UCRoomInformation;
            int id = Convert.ToInt32(clickbooking.Id);
            Account User = GetUserByID(this.UserID);
            HotelInformation hotel = GetHotelInformationByID(this.HotelID);
            Book_room booking = new Book_room(UserID, id, HotelID);
            Room room = GetRoomByID(id);
            if (room != null && hotel!= null && User != null)
            {                  
                booking.SetTime(datetime_checkin.Value, datetime_checkout.Value, room);
                booking.SetData(room, User, hotel);
                booking.RoomID = id;
                booking.UserID = this.UserID;
                booking.ShowDialog();
            }
        }

        private Room GetRoomByID(int id)
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

        private Account GetUserByID(int id)
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

        private HotelInformation GetHotelInformationByID(int id)
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
        private HashSet<string> GetUniqueRoomType()
        {
            HashSet<string> listRoom = new HashSet<string>();
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT RoomType FROM RoomInformation";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hotelLocation = reader["RoomType"].ToString();
                                listRoom.Add(hotelLocation);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listRoom;
        }
        private HashSet<string> GetUniqueRoomBed()
        {
            HashSet<string> listRoom = new HashSet<string>();
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT RoomBed FROM RoomInformation";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hotelLocation = reader["RoomBed"].ToString();
                                listRoom.Add(hotelLocation);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listRoom;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            panel_hide.Visible = false;
            string selectedType = cbx_typeroom.Text.Trim();
            string selectedTypeBed = cbx_typebed.Text.Trim();
            DateTime checkin = datetime_checkin.Value;
            DateTime checkout = datetime_checkout.Value;
            if (!string.IsNullOrEmpty(selectedType) || !string.IsNullOrEmpty(selectedTypeBed))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM RoomInformation WHERE HotelID = @HotelID";
                    if (!string.IsNullOrEmpty(selectedType))
                    {
                        sql += " AND RoomType = @RoomType";
                    }
                    if (!string.IsNullOrEmpty(selectedTypeBed))
                    {
                        sql += " AND RoomBed = @RoomBed";
                    }
                    if (checkin != null && checkout != null)
                    {
                        sql += " AND RoomID NOT IN (SELECT RoomID FROM Booking WHERE (@Checkin < Checkout AND @Checkout > Checkin))";
                    }
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.Add(new SqlParameter("HotelID", HotelID));
                    if (!string.IsNullOrEmpty(selectedType))
                    {
                        command.Parameters.AddWithValue("@RoomType", selectedType);
                    }
                    if (!string.IsNullOrEmpty(selectedTypeBed))
                    {
                        command.Parameters.AddWithValue("@RoomBed", selectedTypeBed);
                    }
                    if (checkin != null)
                    {
                        command.Parameters.AddWithValue("@Checkin", checkin);
                        command.Parameters.AddWithValue("@Checkout", checkout);
                    }
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(data);
                    flowLayoutPanel1.Controls.Clear();
                    createItem(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void datetime_checkin_ValueChanged(object sender, EventArgs e)
        {
            datetime_checkout.MinDate = datetime_checkin.Value.AddDays(1);
        }
    }
}
