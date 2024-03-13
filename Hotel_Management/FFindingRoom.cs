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
    public partial class FFindingRoom : Form
    {
        SqlConnection conn = new
         SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");

        public FFindingRoom()
        {
            InitializeComponent();
            LoadForm();
            createItem();
        }

        public void LoadForm()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM HotelInformation";
                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(data);
                gv_hotel.DataSource = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createItem()
        {
            int count = gv_hotel.Rows.Count;
            if (count > 0)
            {
                UCFindingHotel[] ls = new UCFindingHotel[count];
                for (int i = 0; i < count - 1; i++)
                {
                    ls[i] = new UCFindingHotel();
                    object roomName = gv_hotel.Rows[i].Cells[1].Value;
                    if (roomName != null)
                    {
                        ls[i].HotelName = roomName.ToString();
                    }
                  
                  //  ls[i].Color = Color.DodgerBlue;

                    byte[] image = (byte[])gv_hotel.Rows[i].Cells[6].Value;
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    object HotelLocation = gv_hotel.Rows[i].Cells[2].Value;
                    if (HotelLocation != null)
                    {
                        ls[i].Location = HotelLocation.ToString();
                    }
                  //  ls[i].Ultilities = gv_hotel.Rows[i].Cells[5].Value;
                    ls[i].Price = (Double)gv_hotel.Rows[i].Cells[5].Value;
                    ls[i].Point = (Double)gv_hotel.Rows[i].Cells[4].Value;
                    flowLayoutPanel1.Controls.Add(ls[i]);
                }
            }
        }



    }
}
