using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FBooking : Form
    {
        private int HotelID;
        BookingDAO bookingDAO = new BookingDAO();
  //      private FListRoom fListRoom;
        public FBooking(int hotelID)
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            string dayOfWeek = currentDate.ToString("[ dddd, ", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            lb_date.Text = dayOfWeek + " " + currentDate.ToString("dd/MM/yyyy | HH:mm:ss ]");
            this.HotelID = hotelID;
            LoadForm();
        }

        void LoadForm()
        {
            gvBooking.DataSource = bookingDAO.Load(HotelID);
        }
        private void gvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                int bookingId = Convert.ToInt32(selectedRow.Cells["BookingNumber"].Value);
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);     
                Room room = Instance.GetRoomByID(roomId);
                Account user = Instance.GetUserByID(userId);
                FBookingInformation booking = new FBookingInformation(room, user, HotelID, bookingId);
                (this.MdiParent as Admin)?.ShowForm(booking);
            }
        }

        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FListRoom fListRoom = new FListRoom(HotelID);
            (this.MdiParent as Admin)?.ShowForm(fListRoom);
        }

        private void gvBooking_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = gvBooking.Rows[e.RowIndex];
            if (row.Cells["BookingStatus"].Value != null && row.Cells["BookingStatus"].Value.ToString() == "pending")
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void combx_paymentstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvBooking.DataSource = bookingDAO.Finding(HotelID, combx_paymentstatus, "PaymentStatus");
                gvBooking.Columns["UserID"].Visible = false;
                gvBooking.Columns["HotelID"].Visible = false;
                gvBooking.Columns["RoomID"].Visible = false;
        }

        private void combx_Bookingstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvBooking.DataSource = bookingDAO.Finding(HotelID, combx_Bookingstatus, "BookingStatus");
                gvBooking.Columns["UserID"].Visible = false;
                gvBooking.Columns["HotelID"].Visible = false;
                gvBooking.Columns["RoomID"].Visible = false;
        }

        private void txb_customer_name_TextChanged(object sender, EventArgs e)
        {
            gvBooking.DataSource = bookingDAO.Seacrch(HotelID, txb_customer_name);
                gvBooking.Columns["UserID"].Visible = false;
                gvBooking.Columns["HotelID"].Visible = false;
                gvBooking.Columns["RoomID"].Visible = false;
        }
    }
}
