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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FBookingInformation booking = new FBookingInformation();
            (this.MdiParent as Admin)?.ShowForm(booking);
        }

        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FListRoom fListRoom = new FListRoom(HotelID);           
            (this.MdiParent as Admin)?.ShowForm(fListRoom);
        }

        
    }
}
