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
    public partial class UCFeedback : UserControl
    {
        public UCFeedback()
        {
            InitializeComponent();
        }
        private double _rate;
        private DateTime _date;
        private string _comment;
        private string _email;
        [Category("Custom Props")]
        public double Rate { get => _rate; set { _rate = value; txb_rate.Text = value.ToString() + "/ 10"; } }
        [Category("Custom Props")]
        public DateTime Date { get => _date; set { _date = value; lb_datetime.Text = value.ToString(); } }
        [Category("Custom Props")]
        public string Comment { get => _comment; set { _comment = value; txb_comment.Text = value.ToString(); } }
        [Category("Custom Props")]
        public string Email { get => _email; set { _email = value; lb_email.Text = value; } }
    }
}
