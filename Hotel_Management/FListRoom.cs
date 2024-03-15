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

using System.Data.Common;
using System.Web.UI.WebControls;
using Hotel_Management.Properties;
using System.IO;
using static Guna.UI2.Native.WinApi;
using System.Collections.ObjectModel;

namespace Hotel_Management
{
    public partial class FListRoom : Form
    {
        private int HotelID  ;
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");

        public FListRoom(int hotelID)
        {            
            InitializeComponent();
            LoadForm(hotelID);
            DateTime currentDate = DateTime.Now;
            string dayOfWeek = currentDate.ToString("[ dddd, ", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            lb_date.Text = dayOfWeek + " " + currentDate.ToString("dd/MM/yyyy | HH:mm:ss ]");
            this.HotelID = hotelID;
            createItem();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
           
          
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

        private void ListRoom_Load(object sender, EventArgs e)
        {

        }

        // Tạo list item room trong form 
        private void createItem()
        {
            int count = gvRoom.Rows.Count;
            if (count > 0)
            {
                UCListRoom[] ls = new UCListRoom[count];
                for (int i = 0; i < count-1; i++)
                {
                    ls[i] = new UCListRoom();
                    object roomName = gvRoom.Rows[i].Cells[0].Value;
                    if (roomName != null)
                    {
                        ls[i].RoomID = roomName.ToString();
                    }
                    ls[i].Price = (double)gvRoom.Rows[i].Cells[3].Value;
                    ls[i].Color = Color.DodgerBlue;

                    byte[] image = (byte[])gvRoom.Rows[i].Cells[10].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image)) 
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                  
                    ls[i].Checkin = (DateTime)gvRoom.Rows[i].Cells[8].Value;
                    ls[i].Checkout = (DateTime)gvRoom.Rows[i].Cells[9].Value;
                    ls[i].Status = gvRoom.Rows[i].Cells[6].Value.ToString();
                    if (ls[i].Status == "Empty")
                    {
                        ls[i].btn_Booking.Visible = true;
                    }
                    else if (ls[i].Status == "Occupied")
                    {
                        ls[i].Color = Color.LimeGreen;
                    }
                    ls[i].ItemBooking += Btn_Booking_Click;
                    ls[i].Click += ListRoom_Click;
                 //   ls[i].btn_Booking.Click += Btn_Booking_Click; 
                    flowLayoutPanel1.Controls.Add(ls[i]);
                }
            }
        }

        private void Btn_Booking_Click(object sender, EventArgs e)
        {
            

            UCListRoom clickBooking = sender as UCListRoom;
            FAddNewBooking AddNewBooking = new FAddNewBooking();
            int id = Convert.ToInt32(clickBooking.RoomID);
            Room room = GetRoomByID(id);

            if (room != null)
            {
                (this.MdiParent as Admin)?.ShowForm(AddNewBooking);
            }
        }

        // Lấy data room bằng id của nó
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


        /*
                void Edit(Book book, string id)
                {

                    SqlConnection sqlConnection = Connection.getConnection();

                    string query = "Update Book set Category = @Category, Title = @Title, Author = @Author, ISBN = @ISBN Where ID = @ID;";

                    try
                    {
                        sqlConnection.Open();

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.Add("@ID", SqlDbType.NChar, 50).Value = id;
                        sqlCommand.Parameters.Add("@Category", SqlDbType.NChar, 50).Value = book.Category;
                        sqlCommand.Parameters.Add("@Title", SqlDbType.NChar, 50).Value = book.Title;
                        sqlCommand.Parameters.Add("@Author", SqlDbType.NChar, 50).Value = book.Author;
                        sqlCommand.Parameters.Add("@ISBN", SqlDbType.NChar, 50).Value = book.ISBN;
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }

                }*/

        // event += click
        private void ListRoom_Click(object sender, EventArgs e)
        {
            UCListRoom clickedItem = sender as UCListRoom;
            FRoomInformation roomInformation = new FRoomInformation();
            int id = Convert.ToInt32(clickedItem.RoomID);
            Room room = GetRoomByID(id);

           if (room != null)
            {
                roomInformation.SetData(room);
                (this.MdiParent as Admin)?.ShowForm(roomInformation);
            }

           

        }

        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FAddRoom fAddRoom = new FAddRoom();
            fAddRoom.ShowDialog();
        }

        private void radio_btn_checkall_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_checkall.Checked)
            {
                for (int i = 0; i < checklistbox.Items.Count; i++)
                {
                    checklistbox.SetItemChecked(i, true);
                }
            }
        }

        private void radio_btn_clear_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_btn_clear.Checked)
            {
                for (int i = 0; i < checklistbox.Items.Count; i++)
                {
                    checklistbox.SetItemChecked(i, false);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }   
    }
