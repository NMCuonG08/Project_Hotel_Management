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
            createItem();
            txb_id.Text = HotelID.ToString(); 
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

        private void createItem()
        {
            int count = gvRoom.Rows.Count;
            if (count > 0)
            {
                UCRoomInformation[] ls = new UCRoomInformation[count];
                for (int i = 0; i < count - 1; i++)
                {
                    if (gvRoom.Rows[i].Cells[4].Value.ToString() != "Empty")
                    {
                        continue;
                    }

                    ls[i] = new UCRoomInformation();
                    object roomID = gvRoom.Rows[i].Cells[0].Value;
                    if (roomID != null)
                    {
                        ls[i].Id = (Int32)roomID;
                    }
                    object roomType = gvRoom.Rows[i].Cells[1].Value;
                    if (roomType != null)
                    {
                        ls[i].Roomtype = roomType.ToString();
                    }
                    object roomBed = gvRoom.Rows[i].Cells[2].Value;
                    if (roomBed != null)
                    {
                        ls[i].Roombed = roomBed.ToString();
                    }
                    ls[i].Price = (double)gvRoom.Rows[i].Cells[3].Value;
                    ls[i].HotelSize = (double)gvRoom.Rows[i].Cells[10].Value;
                    byte[] image = (byte[])gvRoom.Rows[i].Cells[8].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].RoomImage = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    ls[i].Capacity = "2";
                    ls[i].ItemBooking += FChoiceRoom_ItemBooking;
                    flowLayoutPanel1.Controls.Add(ls[i]);

                    
                }
            }
        }

        private void FChoiceRoom_ItemBooking(object sender, EventArgs e)
        {
            UCRoomInformation clickbooking = sender as UCRoomInformation;
            int id = Convert.ToInt32(clickbooking.Id);
            Account User = GetUserByID(this.UserID);
            HotelInformation hotel = GetHotelInformationByID(this.HotelID);
            Book_room booking = new Book_room(UserID, id);
            Room room = GetRoomByID(id);
            if (room != null && hotel!= null && User != null)
            {     
                booking.SetData(room,User,hotel);
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


    }
}
