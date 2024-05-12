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
    public partial class UCFindingHotel : UserControl
    {
        public UCFindingHotel()
        {
            InitializeComponent();
           
        }
        public event EventHandler ItemClicked;

        #region Properties
        private int _id;
        private Color _backgroundColor;
        private string _hotelName;
        private string _location;
        private string _ultilities;
        private double _price;
            private Image _image;
        private double _point;
        private string convenience;
        private string convenience2;
        private double _rating;
        [Category("Custom Props")]
        public string HotelName { get => _hotelName; set { _hotelName = value;lb_name.Text = value; } }

        [Category("Custom Props")]
        public string Location { get => _location; set { _location = value; lb_location.Text = value; } }

        [Category("Custom Props")]
        public string Ultilities { get => _ultilities; set { _ultilities = value; lb_ultilities.Text = value; } }

        [Category("Custom Props")]
        public double Price { get => _price; set { _price = value; txb_price.Text = value.ToString() + " $"; } }

        [Category("Custom Props")]
        public Image Image { get => _image; set { _image = value; pctbox.Image = value; } }

        [Category("Custom Props")]
        public double Point { get => _point; set { _point = value;btn_point.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Color BackgroundColor { get => _backgroundColor; set { _backgroundColor = value;this.BackColor = value; } }
        [Category("Custom Props")]
        public int Id { get => _id; set => _id = value; }
        [Category("Custom Props")]
        public string Convenience { get => convenience; set { convenience = value;lb1.Text = value; } }
        [Category("Custom Props")]
        public string Convenience2 { get => convenience2; set { convenience2 = value; } }
         [Category("Custom Props")]
        public double Rating { get => _rating; set { _rating = value; rating.Value = (float)value; } }



        #endregion

        private void UCFindingHotel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void UCFindingHotel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            
        }

        private void UCFindingHotel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = BackgroundColor;
          

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void UCFindingHotel_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, e);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            panel.Visible = true;
            pp.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel.Visible = false;
            pp.Visible = false;
        }
        public void SetPanelVisibility(string panelName)
        {
            Panel panel = this.panel.Controls["panel_" + panelName] as Panel;
            if (panel != null)
            {
                panel.Visible = true;
            }
            else
            {
                Panel otherpanel = this.panel.Controls["panel_" + panelName] as Panel;
                if (otherpanel != null)
                {
                    otherpanel.Visible = true;
                }
            }
        }

        private void lb1_MouseHover(object sender, EventArgs e)
        {
            panel.Visible = true;
            pp.Visible = true;
        }

        private void lb1_MouseLeave(object sender, EventArgs e)
        {
            panel.Visible = false;
            pp.Visible = false;
        }
    }
}
