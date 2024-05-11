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
            SetData();
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

        public void SetData()
        {
            HotelInformation hotel = hotelInformationDAO.GetHotelInformationByID(this.HotelID);
            lb_hotelname.Text = hotel.Name;
            InitializeMap(hotel.Lng_point, hotel.Lat_point);
            rating_hotel.Value = (float)hotel.Score;
            lb_location.Text = hotel.City;
            byte[] image = hotel.HotelImage;
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    pctbox.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            gv_feedback.DataSource = hotelInformationDAO.SetFeedBack(HotelID);
            btn_point.Text = hotelInformationDAO.SetAVG(HotelID).ToString();
            CreateItemFeedBack();
            

        }
        private void CreateItemFeedBack()
        {
            int count = gv_feedback.Rows.Count;
            if (count > 0)
            {
                UCFeedback[] ls = new UCFeedback[count];
                for (int i = 0; i < count - 1; i++)
                {
                    ls[i] = new UCFeedback();
                    object rate = gv_feedback.Rows[i].Cells[1].Value;
                    double ratee;
                    if (rate != null && Double.TryParse(rate.ToString(), out ratee))
                    {
                        ls[i].Rate = ratee;
                    }

                    object comment = gv_feedback.Rows[i].Cells[2].Value;
                    if (comment != null)
                    {
                        ls[i].Comment = comment.ToString();
                    }

                    DateTime date;
                    object dt = gv_feedback.Rows[i].Cells[5].Value;
                    if (dt != null && DateTime.TryParse(dt.ToString(), out date))
                    {
                        ls[i].Date = date;
                    }
                    object user = gv_feedback.Rows[i].Cells[4].Value;
                    int userID;
                    if (user != null && int.TryParse(user.ToString(), out userID))
                    {

                        Account UserG = Instance.GetUserByID(userID);
                        ls[i].Email = UserG.Useremail;
                    }
                    flow.Controls.Add(ls[i]);
                }
            }
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

        private void panel_room_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            
            flow_main.Visible = true;
            panel_room.Visible = false;
            btn_changeroom.FillColor = Color.DarkSalmon;
            btn_details.FillColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flow_main.Visible = false;
            panel_room.Visible = true;
            btn_changeroom.FillColor = Color.White;
            btn_details.FillColor = Color.DarkSalmon;
        }
        private void InitializeMap(double lng, double lat)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(lng, lat);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 15;
        }

        private void flow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
