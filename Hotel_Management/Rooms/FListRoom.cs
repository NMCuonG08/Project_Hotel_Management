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
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management
{
    public partial class FListRoom : Form
    {
        private int HotelID  ;
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        RoomDAO roomDAO = new RoomDAO();
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
            gvRoom.DataSource=  roomDAO.Load(HotelID);
        }

        private void ListRoom_Load(object sender, EventArgs e)
        {
            
        }

        void SetCount()
        {    
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
                        int count = roomDAO.SetCount(s,HotelID);
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
        }
        void Fillter(string s)
        {
            gvRoom.DataSource = roomDAO.Filler(s, HotelID);
            int count = roomDAO.SetCount(s, HotelID);
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

        void Fillter()
            {
                
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
                    cmd.CommandText = sql;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    dataAdapter.Fill(data);
                    gvRoom.DataSource = data;
             
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
        private void DeleteRoom(Room room)
        {
            roomDAO.DeleteRoom(room);
            LoadForm(HotelID);
            createItem();
        }
        private void FListRoom_ItemDelete(object sender, EventArgs e)
        {
            UCListRoom clickBooking = sender as UCListRoom;     
            int id = Convert.ToInt32(clickBooking.RoomID);
            Room room = GetRoomByID(id);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng này không?", "Thong bao", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                DeleteRoom(room);
                message.Show("Delete Successfull!");
            }
        }

        private Room GetRoomByID(int id)
        {
            return roomDAO.GetRoomByID(id); 
        }

       void AddRoom(Room room)
        {    
            Room newroom = new Room(room.Name, room.Type, room.Bed, room.Clients, room.Size, room.Price, room.Image, room.Status, DateTime.Now, DateTime.Now, HotelID);
            roomDAO.AddRoom(newroom);
            LoadForm(HotelID);
            createItem();
        }
        private void EditRoom(Room room)
        {
            Room newroom = new Room(room.Id,room.Name, room.Type, room.Bed, room.Clients, room.Size, room.Price, room.Image, room.Status, DateTime.Now, DateTime.Now, HotelID);
            roomDAO.EditRoom(newroom);
            LoadForm(HotelID);
            createItem();
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
