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
    public partial class UCRoomInformation : UserControl
    {
        public UCRoomInformation()
        {
            InitializeComponent();
            
        }
        public event EventHandler ItemBooking;
        #region Properties
        private int _id;
        private Image _roomImage;
        private String _capacity;
        private double _price;
        private String _ultilities;
        private String _roomtype;
        private String _roombed;
        private double _size;
        [Category("Custom Props")]
        public Image RoomImage { get => _roomImage; set { _roomImage = value; picturebox.Image = value; } }
        [Category("Custom Props")]
        public string Capacity { get => _capacity; set { _capacity = value;txb_capacity.Text = value; } }
        [Category("Custom Props")]
        public double Price { get => _price; set { _price = value; txb_price.Text = value.ToString(); } }
        [Category("Custom Props")]
        public string Ultilities { get => _ultilities; set { _ultilities = value;  } }
        public string Roomtype { get => _roomtype; set { _roomtype = value; lb_roomType.Text = value; } }
        [Category("Custom Props")]
        public string Roombed { get => _roombed; set { _roombed = value; lb_roombed.Text = value; } }
        [Category("Custom Props")]
        public double HotelSize { get => _size; set { _size = value; lb_size.Text = "Area: " +  value.ToString() + " m2"; } }
        [Category("Custom Props")]
        public int Id { get => _id; set => _id = value; }
        #endregion
        private void btn_Booking_Click(object sender, EventArgs e)
        {
            ItemBooking?.Invoke(this, e);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_TV_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetPanelVisibility(string panelName)
        {
            Panel panel = this.flowLayoutPanel1.Controls["panel_" + panelName] as Panel;
            if (panel != null)
            {
                panel.Visible = true;
            }
            else
            {
                Panel otherpanel = this.flowLayoutPanel1.Controls["panel_" + panelName] as Panel;
                if (otherpanel != null)
                {
                    otherpanel.Visible = true;
                }
            }
        }



    }
}
