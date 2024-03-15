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
    public partial class Fcheckout : Form
    {
        public Fcheckout()
        {
            InitializeComponent();
        }

        private void gv_booked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_booked.Columns["btnCheckout"].Index && e.RowIndex >= 0)
            {
                FBookingInformation booking = new FBookingInformation();
                (this.MdiParent as Admin)?.ShowForm(booking);

            }
            if (e.ColumnIndex == gv_booked.Columns["btn_extendbooking"].Index && e.RowIndex >= 0)
            {
                FExtendBooking extendBooking = new FExtendBooking();
                (this.MdiParent as Admin)?.ShowForm(extendBooking);
            }
        }
    }
}
