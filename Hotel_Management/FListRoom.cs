﻿using System;
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
using Guna.UI2.WinForms;

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

        public void LoadForm(int HotelID)
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
                message.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ListRoom_Load(object sender, EventArgs e)
        {
            
        }


        void SetCount()
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();                  
                    List<String> item = new List<String> 
                    {
                        "Empty",
                        "Occupied",
                        "Booking",
                        "Checkout",
                        "Maintenance"
                    };
                    foreach (String  s in item )
                    {
                        string sql2 = string.Format("Select Count(*) from RoomInformation where HotelID = @HotelID AND  Status = '{0}' ", s);
                        SqlCommand command = new SqlCommand(sql2, conn);
                        command.Parameters.AddWithValue("@HotelID", HotelID);
                        int count = (int)command.ExecuteScalar();
                        Guna2Button button = this.panel2.Controls["btn_" + s] as Guna2Button;
                        if (button != null)
                        {
                            button.Text = count.ToString();
                        }
                        else
                        {
                            button.Text = "0";
                        }
                    }
                    conn.Close();
                }
                

            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
            finally
            {
               
            }
        }
        void Fillter(string s)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string sql = string.Format("SELECT * FROM RoomInformation WHERE Status = '{0}' AND HotelID = @HotelID", s);
                  
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@HotelID", HotelID);
                    cmd.CommandText = sql;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);
                    gvRoom.DataSource = data;
                    string sql2 = string.Format("Select Count(*) from RoomInformation where HotelID = @HotelID AND  Status = '{0}' ", s);
                    SqlCommand command = new SqlCommand(sql2, conn);
                    command.Parameters.AddWithValue("@HotelID", HotelID);
                    int count = (int)command.ExecuteScalar();
                    Guna2Button button = this.panel2.Controls["btn_" + s] as Guna2Button;
                    if (button != null )
                    {
                        button.Text = count.ToString();
                    }
                    else
                    {
                        button.Text = "0";
                    }
                }

            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void Fillter()
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM RoomInformation WHERE HotelID = @HotelID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@HotelID", HotelID);
                    if (!string.IsNullOrEmpty(cb_type.Text))
                    {
                        sql += " AND RoomType = @RoomType";
                        cmd.Parameters.AddWithValue("@RoomType", cb_type.Text);
                    }
                    if (!string.IsNullOrEmpty(cb_status.Text))
                    {
                        sql += " AND Status = @Status";
                        cmd.Parameters.AddWithValue("@Status", cb_status.Text);
                    }
                    if (!string.IsNullOrEmpty(cb_typebed.Text))
                    {
                        sql += " AND RoomBed = @RoomBed";
                        cmd.Parameters.AddWithValue("@RoomBed", cb_typebed.Text);
                    }

                    // Thực thi câu lệnh truy vấn
                    cmd.CommandText = sql;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);
                    gvRoom.DataSource = data;
                }
                catch (Exception ex)
                {
                message.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        public void createItem()
        {
            flowLayoutPanel1.Controls.Clear();
            int count = gvRoom.Rows.Count;
            if (count > 0)
            {
                UCListRoom[] ls = new UCListRoom[count];
                for (int i = 0; i < count-1; i++)
                {
                    ls[i] = new UCListRoom();
                    object roomID = gvRoom.Rows[i].Cells[0].Value;
                    if (roomID != null)
                    {
                        ls[i].RoomID = roomID.ToString();
                    }
                    ls[i].Price = (double)gvRoom.Rows[i].Cells[3].Value;
                    ls[i].Color = Color.DodgerBlue;

                    byte[] image = (byte[])gvRoom.Rows[i].Cells[8].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    DateTime checkin;
                    DateTime checkout;
                    object checkinValue = gvRoom.Rows[i].Cells[6].Value;
                    object checkoutValue = gvRoom.Rows[i].Cells[7].Value;
                    if (checkinValue != null && DateTime.TryParse(checkinValue.ToString(), out checkin))
                    {
                        ls[i].Checkin = checkin;
                    }
                    else
                    {                       
                        ls[i].Checkin = DateTime.MinValue;
                    }

                    if (checkoutValue != null && DateTime.TryParse(checkoutValue.ToString(), out checkout))
                    {
                        ls[i].Checkout = checkout;
                    }
                    else
                    {                       
                        ls[i].Checkout = DateTime.MinValue;                                                           
                    }
                    ls[i].Status = gvRoom.Rows[i].Cells[4].Value.ToString();
                    if (ls[i].Status == "Empty")
                    {
                        
                    }
                    else if (ls[i].Status == "Occupied")
                    {
                        ls[i].Color = Color.LimeGreen;
                    }
                    else if (ls[i].Status == "Booking")
                    {
                        ls[i].Color = Color.Purple;
                    }
                    else if (ls[i].Status == "Maintenance")
                    {
                        ls[i].Color = Color.Firebrick;
                    }
                    else if (ls[i].Status == "Checkout")
                    {
                        ls[i].Color = Color.FromArgb(255, 128, 0);
                    }
                   
                    ls[i].Click += ListRoom_Click;
                    ls[i].ItemDelete += FListRoom_ItemDelete;
                    flowLayoutPanel1.Controls.Add(ls[i]);
                    SetCount();
                }
            }
        }
        private void DeleteRoom(int roomID)
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "Delete from RoomInformation where RoomID = @RoomID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomID;
                    sqlCommand.ExecuteNonQuery();
                }
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "Delete from RoomConveniences where RoomID = @RoomID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomID;
                    sqlCommand.ExecuteNonQuery();
                }
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "Delete from Bathroomconveniences where RoomID = @RoomID";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.Parameters.Add("@RoomID", SqlDbType.Int).Value = roomID;
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }

        }
        private void FListRoom_ItemDelete(object sender, EventArgs e)
        {
            UCListRoom clickBooking = sender as UCListRoom;     
            int id = Convert.ToInt32(clickBooking.RoomID);

            DialogResult result = MessageBox.Show("Ban muon xoa no khong", "Thong bao", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DeleteRoom(id);
                message.Show("Delete Successfull!");
                this.Close();
                Connection.Openadmin();
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        

        // Lấy data room bằng id của nó
        private Room GetRoomByID(int id)
        {
            Room room = null;
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
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
                            Image = (byte[])reader["RoomImage"],
                            Checkin = (DateTime)reader["Checkin"],
                            Checkout = (DateTime)reader["Checkout"],

                        };
                    }
                }
            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
            return room;
        }


       void AddRoom(Room room)
        {
            try
            {         
                conn.Open();
                string status = "Empty";
                string query = "Insert into RoomInformation values (@RoomType, @RoomBed,@RoomPrice,@Status,@RoomName,@Checkin,@Checkout,@RoomImage,@Clients,@size,@HotelID)";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.Add(new SqlParameter("RoomType",room.Type));
                sqlCommand.Parameters.Add(new SqlParameter("RoomBed", room.Bed));
                sqlCommand.Parameters.Add(new SqlParameter("RoomPrice", room.Price));
                sqlCommand.Parameters.Add(new SqlParameter("Status", status));
                sqlCommand.Parameters.Add(new SqlParameter("RoomName", room.Name));
                sqlCommand.Parameters.Add(new SqlParameter("Checkin", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("Checkout", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("RoomImage", room.Image));
                sqlCommand.Parameters.Add(new SqlParameter("Clients", room.Clients));
                sqlCommand.Parameters.Add(new SqlParameter("size", room.Size));
                sqlCommand.Parameters.Add(new SqlParameter("HotelID", HotelID));
                sqlCommand.ExecuteNonQuery();
               
                conn.Close();
                LoadForm(HotelID);
                createItem();
            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
        }
        private void EditRoom(Room room)
        {
            try
            {
                conn.Open();
               
                string query = "update RoomInformation set  RoomType = @RoomType, RoomBed = @RoomBed,RoomPrice = @RoomPrice,RoomName = @RoomName,RoomImage  = @RoomImage,Clients= @Clients, Status = @Status,size = @size where RoomID = @RoomID";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Parameters.Add(new SqlParameter("RoomType", room.Type));
                sqlCommand.Parameters.Add(new SqlParameter("RoomBed", room.Bed));
                sqlCommand.Parameters.Add(new SqlParameter("RoomPrice", room.Price));
                sqlCommand.Parameters.Add(new SqlParameter("RoomName", room.Name));
                sqlCommand.Parameters.Add(new SqlParameter("RoomImage", room.Image));
                sqlCommand.Parameters.Add(new SqlParameter("Clients", room.Clients));
                sqlCommand.Parameters.Add(new SqlParameter("size", room.Size));
                sqlCommand.Parameters.Add(new SqlParameter("RoomID", room.Id));
                sqlCommand.Parameters.Add(new SqlParameter("Status", room.Status));
                sqlCommand.ExecuteNonQuery();
                message.Show("Edit successful");
                conn.Close();
                LoadForm(HotelID);
                createItem();
            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
        }


        private void ListRoom_Click(object sender, EventArgs e)
        {
            UCListRoom clickedItem = sender as UCListRoom;
            FRoomInformation roomInformation = new FRoomInformation();
            int id = Convert.ToInt32(clickedItem.RoomID);
            Room room = GetRoomByID(id);
           if (room != null)
            {
                roomInformation.SetData(room);
                roomInformation.editRoom += EditRoom;
                (this.MdiParent as Admin)?.ShowForm(roomInformation);
            }
        }

        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FAddRoom fAddRoom = new FAddRoom(HotelID);
            fAddRoom.addRoom += AddRoom;
            (this.MdiParent as Admin)?.ShowForm(fAddRoom);
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
        #region Button
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Fillter();
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_empty_Click(object sender, EventArgs e)
        {
            try
            {
                Fillter("Empty");
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_occupied_Click(object sender, EventArgs e)
        {
            try
            {
                Fillter("Occupied");
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_booking_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fillter("Booking");
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                Fillter("Checkout");
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Maintenance_Click(object sender, EventArgs e)
        {
            try
            {
                Fillter("Maintenance");
                createItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
