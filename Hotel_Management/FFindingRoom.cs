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
    public partial class FFindingRoom : Form
    {
        SqlConnection conn = new
         SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        private Account User = new Account();
        public FFindingRoom(Account user)
        {
            InitializeComponent();
            this.User = user;
        //    txb_email.Text =User.Useremail;
            LoadForm();
            
        }

        public void LoadForm()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM HotelInformation";
                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(data);
                gv_hotel.DataSource = data;
                createItem(data);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HashSet<string> uniqueHotel = GetUniqueHotelLocation();
            cbx_hotelLocation.DataSource = new BindingSource(uniqueHotel, null);
        }

        private Room GetHotelByID(int id)
        {
            Room room = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = "Select * from HotelInformation where HotelID = @HotelID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@HotelID", SqlDbType.Int).Value = id;
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            Id = Convert.ToInt32(reader["ID"]),
                            Name = reader["RoomName"].ToString(),
                            Type = reader["RoomType"].ToString(),
                            Bed = reader["RoomBed"].ToString(),
                            Price = Convert.ToInt32(reader["RoomPrice"]),
                            Status = reader["Status"].ToString(),
                            Clients = Convert.ToInt32(reader["Clients"]),
                            Size = Convert.ToDouble(reader["Size"]),
                            Image = (byte[])reader["RoomImage"]
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

        private void createItem(DataTable data)
        {
            int count = data.Rows.Count;
            if (count > 0)
            {
                UCFindingHotel[] ls = new UCFindingHotel[count];
                for (int i = 0; i < count; i++)
                {
                    ls[i] = new UCFindingHotel();
                    object roomName = data.Rows[i]["HotelName"];
                    if (roomName != null)
                    {
                        ls[i].HotelName = roomName.ToString();
                    }

                    byte[] image = (byte[])data.Rows[i]["HotelImage"];
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }

                    object HotelLocation = data.Rows[i]["City"];
                    if (HotelLocation != null)
                    {
                        ls[i].Location = HotelLocation.ToString();
                    }

                    ls[i].Price = (Double)data.Rows[i]["Price"];
                    ls[i].Point = (Double)data.Rows[i]["Feedback"];
                    ls[i].Id = (Int32)data.Rows[i]["HotelID"];
                    List<String> con = CheckConvenience(ls[i].Id);
                    if (con.Count >= 1)
                    {
                        ls[i].Convenience = con[0]; 
                        ls[i].Convenience2 = con[1];
                    }
                    else
                    {
                        ls[i].Convenience = "";
                    }
                    
                    foreach (String s in con)
                    {
                        
                        ls[i].SetPanelVisibility(s);
                    }
                    ls[i].Click += FFindingRoom_Click;
                    flowLayoutPanel1.Controls.Add(ls[i]);
                }
            }
        }


        private void FFindingRoom_Click(object sender, EventArgs e)
        {
            UCFindingHotel item = sender as UCFindingHotel;
            
            int id = Convert.ToInt32(item.Id);
            FChoiceRoom choiceRoom = new FChoiceRoom(id,User.Id);
            //   Room room = GetRoomByID(id);
           /* choiceRoom.UserID = user.Id;
            choiceRoom.HotelID = id;*/
            choiceRoom.ShowDialog();
           
        }
        // Set User

        private HashSet<string> GetUniqueHotelLocation()
        {
            HashSet<string> listHotel = new HashSet<string>();
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT City FROM HotelInformation";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hotelLocation = reader["City"].ToString();
                                listHotel.Add(hotelLocation);
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
            return listHotel;
        }

        private void btn_findinghotel_Click(object sender, EventArgs e)
        {
            string selectedLocation = cbx_hotelLocation.Text.Trim();
            if (!string.IsNullOrEmpty(selectedLocation))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM HotelInformation WHERE City = @City";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@City", selectedLocation);
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
                MessageBox.Show("Please select a location.");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<String> CheckConvenience(int hotelID)
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
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@HotelID", hotelID);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string columnName = reader["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return convenienceNames;
        }
    }
}
