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
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        private FListRoom fListRoom;
        public FBooking(int hotelID)
        {
            InitializeComponent();
            this.HotelID = hotelID;
            LoadForm();
        }

        void LoadForm()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Booking where HotelID = @HotelID";
                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@HotelID", HotelID);
                dataAdapter.Fill(data);
                gvBooking.DataSource = data;
                gvBooking.Columns["UserID"].Visible = false;
                gvBooking.Columns["HotelID"].Visible = false;
                gvBooking.Columns["RoomID"].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo rằng chỉ khi một dòng được chọn
            {
                DataGridView dgv = sender as DataGridView;
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Lấy dữ liệu từ các ô trong dòng đã chọn
                int bookingId = Convert.ToInt32(selectedRow.Cells["BookingNumber"].Value);
                int roomId = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);     
                Room room = Instance.GetRoomByID(roomId);
                Account user = Instance.GetUserByID(userId);
                FBookingInformation booking = new FBookingInformation(room, user, HotelID, bookingId);

                // Hiển thị form
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
    }
}
