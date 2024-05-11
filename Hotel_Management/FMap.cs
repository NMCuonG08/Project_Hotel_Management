using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FMap : Form
    {
        public FMap()
        {
            InitializeComponent();
            InitializeMap();
        }
        private void InitializeMap()
        {

            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            // Thiết lập vị trí ban đầu của bản đồ (Ví dụ: Thành phố Hồ Chí Minh)
            gmap.Position = new GMap.NET.PointLatLng(10.762622, 106.660172);

            // Thiết lập các thuộc tính zoom
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 17;

            // Đặt sự kiện click chuột trên bản đồ
            gmap.MouseClick += gmap_MouseClick;
        }
      
       
        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            PointLatLng point = gmap.FromLocalToLatLng(e.X, e.Y);
       //     MessageBox.Show("Latitude: " + point.Lat + ", Longitude: " + point.Lng);
            txb1.Text = point.Lat.ToString();
            txb2.Text = point.Lng.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public delegate void Map(double lng, double lat);
        public Map setMap;

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            double latitude = double.Parse(txb1.Text);
            double longitude = double.Parse(txb2.Text);
            setMap(latitude, longitude);
            this.Close();
        }
    }
}
