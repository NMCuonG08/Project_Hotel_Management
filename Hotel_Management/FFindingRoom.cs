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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management
{
    public partial class FFindingRoom : Form
    {
        SqlConnection conn = new
         SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        private Account User = new Account();
        public FFindingRoom(Account user)
        {
            InitializeComponent();
            this.User = user;
            LoadForm();
            processbar.Minimum = 0;
            processbar.Maximum = 10000;
            processbar.Scroll += Processbar_Scroll;          
            processbarmax.Maximum = 10000;
            processbarmax.Scroll += Processbarmax_Scroll;
            lb_email.Text = user.Useremail;
        }

        private void Processbarmax_Scroll(object sender, ScrollEventArgs e)
        {
            txb_maxvalue.Text = (processbar.Value + processbarmax.Value).ToString();
        }

        private void Processbar_Scroll(object sender, ScrollEventArgs e)
        {
            txb_minvalue.Text = processbar.Value.ToString();
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
                createItem(data);
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HashSet<string> uniqueHotel = GetUniqueHotelLocation();
            cbx_hotelLocation.DataSource = new BindingSource(uniqueHotel, null);
           
           
        }

        private double rating(int HotelID)
        {
            double rating = 0;

            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string query = "Select AVG(Rate) from Evaluate where HotelID = @hotelID";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.Add("@hotelID", HotelID);
                    object result = sqlCommand.ExecuteScalar();
                    if (result != DBNull.Value) 
                    {
                        rating = Convert.ToDouble(result);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rating;
        } 

        private void createItem(DataTable data)
        {
            int count = data.Rows.Count;
            if (count > 0)
            {
                UCFindingHotel[] ls = new UCFindingHotel[count];
                for (int i = 0; i < count; i++)
                {
                    ls[i] = new UCFindingHotel();
                    object roomName = data.Rows[i]["HotelName"];
                    if (roomName != null)
                    {
                        ls[i].HotelName = roomName.ToString();
                    }

                    byte[] image = (byte[])data.Rows[i]["HotelImage"];
                    if (image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(image))
                        {
                            ls[i].Image = System.Drawing.Image.FromStream(ms);
                        }
                    }

                    object HotelLocation = data.Rows[i]["City"];
                    if (HotelLocation != null)
                    {
                        ls[i].Location = HotelLocation.ToString();
                    }

                    ls[i].Price = (Double)data.Rows[i]["Price"];
                    ls[i].Rating = (Double)data.Rows[i]["FeedBack"];
                    ls[i].Id = (Int32)data.Rows[i]["HotelID"];
                    if (rating(ls[i].Id) != null)
                    {
                        ls[i].Point = rating(ls[i].Id);
                    }
                    else
                    {
                        ls[i].Point = 0;
                    }
                    List<String> con = CheckConvenience(ls[i].Id);
                    if (con.Count >= 1)
                    {
                        ls[i].Convenience = con[0]; 
                        ls[i].Convenience2 = con[1];
                        foreach (String s in con)
                        {

                            ls[i].SetPanelVisibility(s);
                        }
                    }
                    else
                    {
                        ls[i].Convenience = "";
                    }
                    
                    
                    ls[i].Click += FFindingRoom_Click;
                    flowpanel.Controls.Add(ls[i]);
                }
            }
        }


        private void FFindingRoom_Click(object sender, EventArgs e)
        {
            UCFindingHotel item = sender as UCFindingHotel;
            
            int id = Convert.ToInt32(item.Id);
            FChoiceRoom choiceRoom = new FChoiceRoom(id,User.Id);
            //   Room room = GetRoomByID(id);
           /* choiceRoom.UserID = user.Id;
            choiceRoom.HotelID = id;*/
            choiceRoom.ShowDialog();
           
        }
        // Set User

        private HashSet<string> GetUniqueHotelLocation()
        {
            HashSet<string> listHotel = new HashSet<string>();
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string query = "SELECT City FROM HotelInformation";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string hotelLocation = reader["City"].ToString();
                                listHotel.Add(hotelLocation);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listHotel;
        }

        private void btn_findinghotel_Click(object sender, EventArgs e)
        {
            string selectedLocation = cbx_hotelLocation.Text.Trim();
           
                try
                {
                    conn.Open();  
                    string sql = @"SELECT HI.* 
                           FROM HotelInformation HI 
                           JOIN Hotel_conveniences HC ON HI.HotelID = HC.HotelID 
                           WHERE 1=1";

                    if (!string.IsNullOrEmpty(selectedLocation))
                    {
                    sql += $" AND  HI.City = @City";
                }
                    foreach (object item in checkedListBox_convenience.CheckedItems)
                    {
                        string checkedItem = item.ToString();
                        if (!string.IsNullOrEmpty(checkedItem))
                        {
                            sql += $" AND HC.[{checkedItem}] = 1";
                        }
                    }

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@City", selectedLocation);
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(data);

                    flowpanel.Controls.Clear();
                    createItem(data);
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



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<String> CheckConvenience(int hotelID)
        {
            List<string> convenienceNames = new List<string>();
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string sqlQuery = @"
                                        SELECT COLUMN_NAME 
                                        FROM INFORMATION_SCHEMA.COLUMNS 
                                        WHERE TABLE_NAME = 'Hotel_conveniences' 
                                        AND DATA_TYPE = 'bit' 
                                        AND COLUMN_NAME <> 'HotelID' 
                                        AND COLUMN_NAME IN (
                                            SELECT 'Breakfast' FROM Hotel_conveniences WHERE Breakfast = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Free_WiFi' FROM Hotel_conveniences WHERE Free_WiFi = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT '247_Room_Service' FROM Hotel_conveniences WHERE [247_Room_Service] = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Daily_Housekeeping' FROM Hotel_conveniences WHERE Daily_Housekeeping = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Restaurant_and_Bar' FROM Hotel_conveniences WHERE Restaurant_and_Bar = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Swimming_Pool_and_Spa' FROM Hotel_conveniences WHERE Swimming_Pool_and_Spa = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Laundry_Service' FROM Hotel_conveniences WHERE Laundry_Service = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Parking_area' FROM Hotel_conveniences WHERE Parking_area = 1 AND HotelID = @HotelID
                                            UNION
                                            SELECT 'Gym' FROM Hotel_conveniences WHERE Gym = 1 AND HotelID = @HotelID
                                        );
                                    ";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@HotelID", hotelID);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string columnName = reader["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return convenienceNames;
        }

        private void btn_lowprice_Click(object sender, EventArgs e)
        {
            conn.Open();
            flowpanel.Controls.Clear();
            string sql = "SELECT * FROM HotelInformation ORDER BY Price";
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            conn.Close();
        }

        private void btn_highprice_Click(object sender, EventArgs e)
        {
            conn.Open();
            flowpanel.Controls.Clear();
            string sql = "SELECT * FROM HotelInformation ORDER BY Price DESC;";
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            conn.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            flowpanel.Controls.Clear();
            LoadForm();
            
        }

        private void btn_feed_Click(object sender, EventArgs e)
        {
            conn.Open();
            flowpanel.Controls.Clear();
            string sql = "SELECT * FROM HotelInformation ORDER BY Feedback DESC;";
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            conn.Close();
        }

        private void listcheckbox_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            int min = 5, max = 0;
            foreach (object item in listcheckbox_start.CheckedItems)
            {
                int checkedItem = Convert.ToInt32(item.ToString());
                if (checkedItem < min)
                {
                    min = checkedItem;
                }
                if (checkedItem > max)
                {
                    max = checkedItem;
                }
            }
            max = max;
            min = min - 1;
           
            string sql = String.Format("SELECT * FROM HotelInformation WHERE Feedback <= {0} AND Feedback >= {1}", max, min);
            conn.Open();
            flowpanel.Controls.Clear();
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            conn.Close();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            FUserInformation userinfo  = new FUserInformation(User.Id);
            userinfo.ShowDialog();
            if (Instance.Isloggedout) this.Close();
        }

        private void panel_sx_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox_convenience_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_minvalue_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            flowpanel.Controls.Clear();
            string sql = String.Format("SELECT * FROM HotelInformation WHERE Price <= {0} AND Price >= {1}", txb_maxvalue.Text.ToString(), txb_minvalue.Text.ToString());
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            
            conn.Close();
        }

        private void txb_maxvalue_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            flowpanel.Controls.Clear();
            string sql = String.Format("SELECT * FROM HotelInformation WHERE Price <= {0} AND Price >= {1}", txb_maxvalue.Text.ToString(), txb_minvalue.Text.ToString());
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(data);
            gv_hotel.DataSource = data;
            createItem(data);
            conn.Close();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void processbar_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}
