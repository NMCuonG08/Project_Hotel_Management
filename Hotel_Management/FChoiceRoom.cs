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
        RoomDAO roomDAO = new RoomDAO();
        HotelInformationDAO hotelInformationDAO = new HotelInformationDAO();
        AccountDAO accountDAO = new AccountDAO();
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
            DataTable data = roomDAO.Load(HotelID);
                gvRoom.DataSource = data;
                createItem(data);        
            HashSet<string> uniqueRoomType = roomDAO.GetUniqueOfRoom("RoomType");
            cbx_typeroom.DataSource = new BindingSource(uniqueRoomType, null);
            HashSet<string> uniqueRoomBed =roomDAO.GetUniqueOfRoom("RoomBed");
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
                    List<String> con = roomDAO.CheckConvenience(ls[i].Id);
                    foreach (String s in con)
                    {
                        ls[i].SetPanelVisibility(s);
                    }
                    ls[i].ItemBooking += FChoiceRoom_ItemBooking;
                    panel_room.Controls.Add(ls[i]);                   
                }
            }
        }

        
        private void FChoiceRoom_ItemBooking(object sender, EventArgs e)
        {
            UCRoomInformation clickbooking = sender as UCRoomInformation;
            int id = Convert.ToInt32(clickbooking.Id);
            Account User =accountDAO.GetUserByID(this.UserID);
            HotelInformation hotel = hotelInformationDAO.GetHotelInformationByID(this.HotelID);
            FBook_room booking = new FBook_room(UserID, id, HotelID);
            Room room = roomDAO.GetRoomByID(id);
            if (room != null && hotel!= null && User != null)
            {                  
                booking.SetTime(datetime_checkin.Value, datetime_checkout.Value, room);
                booking.SetData(room, User, hotel);
                booking.RoomID = id;
                booking.UserID = this.UserID;
                booking.ShowDialog();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {         
            string selectedType = cbx_typeroom.Text.Trim();
            string selectedTypeBed = cbx_typebed.Text.Trim();
            DateTime checkin = datetime_checkin.Value;
            DateTime checkout = datetime_checkout.Value;
            if (!string.IsNullOrEmpty(selectedType) || !string.IsNullOrEmpty(selectedTypeBed))
            {
                    DataTable data = roomDAO.Search(HotelID, selectedType,selectedTypeBed,checkin,checkout);
                    panel_room.Controls.Clear();
                    createItem(data);
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
