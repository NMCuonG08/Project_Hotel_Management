using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Hotel_Management
{
  
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            Customer();
            Room_sss();
            User_sss();
           
        }
        SqlConnection conn = new
         SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        
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
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserRegister where role='"+roleee+"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            label_user.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb_searchss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txb_searchss.SelectedIndex == 0)
            {
                string query = "Select ID,CustomerName,CheckIn,CheckOut,BookingDate,PaymentStatus,UserID from Booking ";
                conn.Open();
              SqlDataAdapter dms=new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                dms.Fill(dt);
                guna2DataGridView1.DataSource=dt;
                conn.Close();
            } else if(txb_searchss.SelectedIndex == 1)
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
