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
            createItem();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void createItem()
        {
            int count = gv_hotel.Rows.Count;
            if (count > 0)
            {
                UCFindingHotel[] ls = new UCFindingHotel[count];
                for (int i = 0; i < count - 1; i++)
                {
                    ls[i] = new UCFindingHotel();
                    object roomName = gv_hotel.Rows[i].Cells[1].Value;
                    if (roomName != null)
                    {
                        ls[i].HotelName = roomName.ToString();
                    }
                

                    byte[] image = (byte[])gv_hotel.Rows[i].Cells[6].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    object HotelLocation = gv_hotel.Rows[i].Cells[2].Value;
                    if (HotelLocation != null)
                    {
                        ls[i].Location = HotelLocation.ToString();
                    }
                  //  ls[i].Ultilities = gv_hotel.Rows[i].Cells[5].Value;
                    ls[i].Price = (Double)gv_hotel.Rows[i].Cells[5].Value;
                    ls[i].Point = (Double)gv_hotel.Rows[i].Cells[4].Value;
                    ls[i].Id = (Int32)gv_hotel.Rows[i].Cells[0].Value;
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
       

        
    }
}
