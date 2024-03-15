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
        public int hotelID;
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        private FListRoom fListRoom;
        public FBooking(int hotelID)
        {
            InitializeComponent();
            LoadForm();
            this.hotelID = hotelID;
        }

        void LoadForm()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Booking";

                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(data);
                gvBooking.DataSource = data;
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
            FListRoom fListRoom = new FListRoom(hotelID);
            
            (this.MdiParent as Admin)?.ShowForm(fListRoom);
        }

        
    }
}
