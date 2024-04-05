using System;
using System.Collections;
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
    public partial class Fcheckout : Form
    {
        private int HotelID;
        public Fcheckout(int hotelID)
        {
            InitializeComponent();
            this.HotelID = hotelID;
            Getdata();
        }
        public void Getdata()
        {
            using (SqlConnection con = Connection.GetSqlConnection())
            {
                con.Open();
                string qury = "select ID,CustomerName,CheckIn,CheckOut from Booking where HotelID = @HotelID ";
                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qury, con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@HotelID", HotelID);
                dataAdapter.Fill(data);
                gv_book.DataSource = data;
               /* ListBox lb = new ListBox();
                lb.Items.Add(HlID);
                lb.Items.Add(CustomerName);
                lb.Items.Add(CustomerPhone);
                lb.Items.Add(RoomNo);             
                lb.Items.Add(Checkin);
                lb.Items.Add(Checkout);
               */
               con.Close();
            }
        }
        private void gv_booked_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_book.CurrentCell.OwningColumn.Name == "Hledit")
            {
                Sampleupdatecheckout sam = new Sampleupdatecheckout();
                sam.id = Convert.ToInt32(gv_book.CurrentRow.Cells["ID"].Value);
                sam.txb_name.Text = Convert.ToString(gv_book.CurrentRow.Cells["CustomerName"].Value);               
                sam.datecheckin.Text = Convert.ToString(gv_book.CurrentRow.Cells["CheckIn"].Value);
                sam.datecheckout.Text = Convert.ToString(gv_book.CurrentRow.Cells["CheckOut"].Value);
                sam.ShowDialog();
                Getdata();
            }
            if (gv_book.CurrentCell.OwningColumn.Name == "Hldele")
            {
                // need confirm before 
                int id = Convert.ToInt32(gv_book.CurrentRow.Cells["ID"].Value);
                string qury = "Delete from Booking where ID=" + id + "";
                Hashtable ht = new Hashtable();
                ClassCheckout.SQL(qury, ht);
                MessageBox.Show("Delete successfully");
                Getdata();
            }
        }
    }
}
