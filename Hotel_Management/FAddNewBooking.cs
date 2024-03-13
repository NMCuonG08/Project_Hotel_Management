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
    public partial class FAddNewBooking : Form
    {
        public FAddNewBooking()
        {
            InitializeComponent();
        }

        private void clb_requied_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if  (e.Index == 3 && clb_requied.GetItemCheckState(3) == CheckState.Unchecked)
            {
                rtxb_other.Visible = true;
            }
            else if (clb_requied.GetItemCheckState(3) == CheckState.Checked)
            {
                rtxb_other.Visible=false;
            }
        }
    }
}
