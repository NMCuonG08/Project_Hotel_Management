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
    public partial class UCListRoom : UserControl
    {

        public event EventHandler ItemClicked;

        public event EventHandler ItemBooking;


        public UCListRoom()
        {
            InitializeComponent();
        }
        #region Properties
        private Color _backgroundColor;
        private String _id;
        private String _status;
        private Image _image;
        private DateTime _checkin;
        private DateTime _checkout;
        private double _price;
        [Category("Custom Props")]
        public String RoomID { get { return _id; } set { _id = value; lb_name.Text = "No 0"+  value  ; } }

        [Category("Custom Props")]
        public String Status { get { return _status; } set { _status = value;lb_status.Text = "[ " + value + " ]"; } }

        [Category("Custom Props")]
        public Image Image { get { return _image; } set { _image = value;pctbox.Image = value; } }
        [Category("Custom Props")]
        public Color Color { get { return _backgroundColor; } set { _backgroundColor = value; this.BackColor = value; } }
        [Category("Custom Props")]
        public DateTime Checkin { get { return _checkin; } set { _checkin = value; txb_Checkin.Text = value.ToString(); } }
        [Category("Custom Props")]
        public DateTime Checkout { get { return _checkout; } set { _checkout = value; txb_checkout.Text = value.ToString(); } }

        [Category("Custom Props")]
        public Double Price { get { return _price; } set { _price = value; txb_price.Text = value.ToString() + " $"; } }
        #endregion

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void UCListRoom_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void UCListRoom_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UCListRoom_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _backgroundColor;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void UCListRoom_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, e);
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            ItemBooking?.Invoke(this, e);
        }

        private void UCListRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
