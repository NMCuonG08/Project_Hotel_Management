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
    public partial class FReport : Form
    {
        int HotelID;
        public FReport(int hotelID)
        {
            this.HotelID = hotelID;
            InitializeComponent();
        }
       SqlConnection conn = Connection.GetSqlConnection();

        public void Customer()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from Booking", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label_customer.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        public void Room_sss()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from RoomInformation", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label_room.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        public void User_sss()
        {
            string roleee = "User";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserRegister where role='" + roleee + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label_user.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb_searchss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txb_searchss.SelectedIndex == 0)
            {
                string query = "Select ID,CustomerName,CheckIn,CheckOut,BookingDate,PaymentStatus,UserID from Booking ";
                conn.Open();
                SqlDataAdapter dms = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dms.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                conn.Close();
            }
            else if (txb_searchss.SelectedIndex == 1)
            {
                string query1 = "Select RoomID,RoomType,RoomBed,RoomPrice,RoomName,Clients from RoomInformation ";
                conn.Open();
                SqlDataAdapter dsm = new SqlDataAdapter(query1, conn);
                DataTable dts = new DataTable();
                dsm.Fill(dts);
                guna2DataGridView1.DataSource = dts;
                conn.Close();
            }
        }

    }
}
