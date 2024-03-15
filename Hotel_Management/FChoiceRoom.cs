using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FChoiceRoom : Form
    {
        public int HotelID ;
        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");

        public FChoiceRoom(int hotelID)
        {
            InitializeComponent();
            this.HotelID = hotelID;
            LoadForm(HotelID);
            createItem();
        }
        void LoadForm(int HotelID)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM RoomInformation where HotelID = @HotelID ";

                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@HotelID", HotelID);
                dataAdapter.Fill(data);
                gvRoom.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void createItem()
        {
            int count = gvRoom.Rows.Count;
            if (count > 0)
            {
                UCRoomInformation[] ls = new UCRoomInformation[count];
                for (int i = 0; i < count - 1; i++)
                {
                    ls[i] = new UCRoomInformation();
                    object roomType = gvRoom.Rows[i].Cells[1].Value;
                    if (roomType != null)
                    {
                        ls[i].Roomtype = roomType.ToString();
                    }
                    object roomBed = gvRoom.Rows[i].Cells[2].Value;
                    if (roomBed != null)
                    {
                        ls[i].Roombed = roomBed.ToString();
                    }
                    ls[i].Price = (double)gvRoom.Rows[i].Cells[3].Value;
                    ls[i].HotelSize = (double)gvRoom.Rows[i].Cells[12].Value;
                    byte[] image = (byte[])gvRoom.Rows[i].Cells[10].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].RoomImage = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    ls[i].Capacity = "2";
                   
              
                    flowLayoutPanel1.Controls.Add(ls[i]);
                }
            }
        }



    }
}
