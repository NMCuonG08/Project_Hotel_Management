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
        #region Properties
        private Image _roomImage;
        private String _capacity;
        private double _price;
        private String _ultilities;
        private String _roomtype;
        private String _roombed;
        private double _size;

        public Image RoomImage { get => _roomImage; set { _roomImage = value; picturebox.Image = value; } }
        public string Capacity { get => _capacity; set { _capacity = value;txb_capacity.Text = value; } }
        public double Price { get => _price; set { _price = value; txb_price.Text = value.ToString(); } }
        public string Ultilities { get => _ultilities; set { _ultilities = value;  } }
        public string Roomtype { get => _roomtype; set { _roomtype = value; lb_roomtype.Text = value; } }
        public string Roombed { get => _roombed; set { _roombed = value; lb_roombed.Text = value; } }

        public double HotelSize { get => _size; set { _size = value; lb_size.Text = value.ToString(); } }
        // private 



        #endregion
    }
}
