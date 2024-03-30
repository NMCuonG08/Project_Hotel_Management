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
    public partial class FHotelInformation : Form
    {

        public int AdminID { get; set; }
        public FHotelInformation(int adminID)
        {
            InitializeComponent();
            this.AdminID = adminID;
            if (CheckHotelExist())
            {
                btn_create.Visible = false;
                btn_update.Visible = true;
            }
            else
            {
                btn_update.Visible=false;
                btn_create.Visible=true;
            }
            setDataHotel();
        }

        private HotelInformation ReadData(int adminID)
        {
            HotelInformation hotel = null;
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                string query = "select * from HotelInformation where AdminID =@adminID ";
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@adminID", adminID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                hotel = new HotelInformation
                                {
                                    Id = reader.IsDBNull(reader.GetOrdinal("HotelID")) ? 0 : (Int32)reader["HotelID"],
                                    Name = reader.IsDBNull(reader.GetOrdinal("HotelName")) ? "" : (String)reader["HotelName"],
                                    PhoneNumber = reader.IsDBNull(reader.GetOrdinal("PhoneNumber")) ? "" : reader["PhoneNumber"].ToString(),
                                    Email = reader.IsDBNull(reader.GetOrdinal("email")) ? "" : reader["email"].ToString(),
                                    Country = reader.IsDBNull(reader.GetOrdinal("Country")) ? "" : reader["Country"].ToString(),
                                    City = reader.IsDBNull(reader.GetOrdinal("City")) ? "" : reader["City"].ToString(),
                                    Street = reader.IsDBNull(reader.GetOrdinal("Street")) ? "" : reader["Street"].ToString(),
                                    Capacity = reader.IsDBNull(reader.GetOrdinal("Capacity")) ? 0 : (Int32)reader["Capacity"],
                                    Floors = reader.IsDBNull(reader.GetOrdinal("FloorsNumber")) ? 0 : (Int32)reader["FloorsNumber"],
                                    Zipcode = reader.IsDBNull(reader.GetOrdinal("zipcode")) ? "" : reader["zipcode"].ToString(),
                                    Description = reader.IsDBNull(reader.GetOrdinal("Descriptions")) ? "" : reader["Descriptions"].ToString(),
                                    Score = reader.IsDBNull(reader.GetOrdinal("Feedback")) ? 0.0 : (Double)reader["Feedback"],
                                    Price = reader.IsDBNull(reader.GetOrdinal("Price")) ? 0.0 : (Double)reader["Price"],
                                    HotelImage = (byte[])reader["HotelImage"]
                                };
                            }
                        }
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message );
                }
            }
            return hotel;
        }

        private void SetConveniences(int HotelID)
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string getHotelConvenienceQuery = $"SELECT * FROM Hotel_conveniences WHERE HotelID = {HotelID}";
                    using (SqlCommand getHotelConveniencesCmd = new SqlCommand(getHotelConvenienceQuery, connection))
                    {
                        using (SqlDataReader reader = getHotelConveniencesCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int i = 1; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);
                                    bool value = Convert.ToBoolean(reader[columnName]);
                                    if (value)
                                    {
                                        int index = checklistbox.Items.IndexOf(columnName);
                                        if (index != -1)
                                        {
                                            checklistbox.SetItemChecked(index, true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void setDataHotel()
        {
            HotelInformation hotel = ReadData(AdminID);
            if (hotel != null)
            {
                txb_hotelID.Text = hotel.Id.ToString();
               txb_name.Text = hotel.Name;
                txb_phoneNumber.Text = hotel.PhoneNumber;
                txb_email.Text = hotel.Email;
                txb_country.Text = hotel.Country;
                txb_capacity.Text = hotel.Capacity.ToString();
                txb_floor.Text = hotel.Floors.ToString();
                txb_feedback.Text = hotel.Score.ToString();
                txb_price.Text = hotel.Price.ToString();
                txb_street.Text = hotel.Street.ToString();
                txb_zip.Text = hotel.Zipcode;
                txb_decription.Text = hotel.Description;
                txb_city.Text = hotel.City;

                byte[] image = hotel.HotelImage;
                if (image != null)
                {
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        picturebox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                SetConveniences(hotel.Id);
            }
            else
            {
                txb_name.Text = "";
                txb_phoneNumber.Text = "";
                txb_email.Text = "";
                txb_country.Text = "";
                txb_capacity.Text = "";
                txb_floor.Text = "";
                txb_feedback.Text = "";
                txb_price.Text = "";
                txb_street.Text = "";
                txb_zip.Text = "";
                txb_decription.Text = "";
                txb_city.Text = "";
            }
        }


        private void HotelInformation_Load(object sender, EventArgs e)
        {

        }
        public void EditHotelConvenience(int HotelID)
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string updateRoomConveniencesQuery = "UPDATE Hotel_conveniences SET ";
                    for (int i = 0; i < checklistbox.Items.Count; i++)
                    {
                        string columnName = checklistbox.Items[i].ToString();
                        bool isChecked = checklistbox.GetItemChecked(i);
                        updateRoomConveniencesQuery += $"[{columnName}] = {(isChecked ? 1 : 0)}, ";
                    }
                    updateRoomConveniencesQuery = updateRoomConveniencesQuery.TrimEnd(',', ' ') + $" WHERE HotelID = {HotelID}";

                    using (SqlCommand cmd = new SqlCommand(updateRoomConveniencesQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateHotel() 
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    if (CheckDataEmpty())
                    {
                        string query = "update HotelInformation set HotelName = @HotelName,City = @City,Street= @Street,FeedBack= @FeedBack,Price= @Price,HotelImage= @HotelImage,email= @email,zipcode= @zipcode,FloorsNumber=  @FloorsNumber,Capacity= @Capacity,PhoneNumber= @PhoneNumber,Country= @Country, Descriptions=@Descriptions  where AdminID = @AdminID";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.Add(new SqlParameter("@HotelName", txb_name.Text));
                            command.Parameters.Add(new SqlParameter("@City", txb_city.Text));
                            command.Parameters.Add(new SqlParameter("@Street", txb_street.Text));
                            command.Parameters.Add(new SqlParameter("@FeedBack", txb_feedback.Text));
                            command.Parameters.Add(new SqlParameter("@Price", txb_price.Text));
                            byte[] imageBytes;
                            using (MemoryStream stream = new MemoryStream())
                            {
                                picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                imageBytes = stream.ToArray();
                            }
                            command.Parameters.Add(new SqlParameter("@HotelImage", imageBytes));
                            command.Parameters.Add(new SqlParameter("@email", txb_email.Text));
                            command.Parameters.Add(new SqlParameter("@zipcode", txb_zip.Text));
                            command.Parameters.Add(new SqlParameter("@FloorsNumber", txb_floor.Text));
                            command.Parameters.Add(new SqlParameter("@Capacity", txb_capacity.Text));
                            command.Parameters.Add(new SqlParameter("@PhoneNumber", txb_phoneNumber.Text));
                            command.Parameters.Add(new SqlParameter("@Country", txb_country.Text));
                            command.Parameters.Add(new SqlParameter("@AdminID", AdminID));
                            command.Parameters.Add(new SqlParameter("@Descriptions", txb_decription.Text));
                            command.ExecuteNonQuery();
                            int hotelID = Convert.ToInt32(txb_hotelID.Text);
                            EditHotelConvenience(hotelID);
                            MessageBox.Show("Update Successful!");
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbn_update_Click(object sender, EventArgs e)
        {
            UpdateHotel();
            FHotelInformation fHotelInformation = new FHotelInformation(AdminID);
            (this.MdiParent as Admin)?.ShowForm(fHotelInformation);

        }
        string imageLocation = "";
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.* ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                picturebox.ImageLocation = imageLocation;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picturebox.Image = null;
        }
        private bool CheckHotelExist()
        {
            bool exists = false; 
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM HotelInformation WHERE AdminID = @AdminID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {                   
                        command.Parameters.AddWithValue("@AdminID", AdminID);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            exists = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }

            return exists;
        }
        private void CreateHotelConvenience()
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    int maxHotelID;
                    string getMaxHotelIDQuery = "SELECT MAX(HotelID) FROM HotelInformation";
                    using (SqlCommand getMaxRoomIDCmd = new SqlCommand(getMaxHotelIDQuery, connection))
                    {
                        object result = getMaxRoomIDCmd.ExecuteScalar();
                        maxHotelID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                    int newHotelID = maxHotelID;

                    string addHotelConvenienceQuery = "INSERT INTO Hotel_conveniences (HotelID) VALUES (@HotelID)";
                    using (SqlCommand addHotelConvenienceCmd = new SqlCommand(addHotelConvenienceQuery, connection))
                    {
                        addHotelConvenienceCmd.Parameters.AddWithValue("@HotelID", newHotelID);
                        addHotelConvenienceCmd.ExecuteNonQuery();
                    }
                   
                    foreach (object itemChecked in checklistbox.CheckedItems)
                    {
                        string updateQuery = "UPDATE Hotel_conveniences SET ";
                        string itemName = itemChecked.ToString();
                        updateQuery += $"[{itemName}] = 1 WHERE HotelID = @HotelID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@HotelID", newHotelID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool CheckDataEmpty()
        {
            return true;
        }
        private void CreateHotel()
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    if (CheckDataEmpty())
                    {
                        string query = "Insert into HotelInformation values (@HotelName, @City, @Street, @FeedBack, @Price, @HotelImage, @email, @zipcode, @FloorsNumber, @Capacity, @PhoneNumber, @Country, @AdminID, @Descriptions) ";
                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.Add(new SqlParameter("@HotelName", txb_name.Text));
                            command.Parameters.Add(new SqlParameter("@City", txb_city.Text));
                            command.Parameters.Add(new SqlParameter("@Street", txb_street.Text));
                            command.Parameters.Add(new SqlParameter("@FeedBack", txb_feedback.Text));
                            command.Parameters.Add(new SqlParameter("@Price", txb_price.Text));
                            byte[] imageBytes;
                            using (MemoryStream stream = new MemoryStream())
                            {
                                picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png); 
                                imageBytes = stream.ToArray();
                            }
                            command.Parameters.Add(new SqlParameter("@HotelImage", imageBytes));
                            command.Parameters.Add(new SqlParameter("@email", txb_email.Text));
                            command.Parameters.Add(new SqlParameter("@zipcode", txb_zip.Text));
                            command.Parameters.Add(new SqlParameter("@FloorsNumber", txb_floor.Text));
                            command.Parameters.Add(new SqlParameter("@Capacity", txb_capacity.Text));
                            command.Parameters.Add(new SqlParameter("@PhoneNumber", txb_phoneNumber.Text));
                            command.Parameters.Add(new SqlParameter("@Country", txb_country.Text));
                            command.Parameters.Add(new SqlParameter("@AdminID", AdminID));
                            command.Parameters.Add(new SqlParameter("@Descriptions", txb_decription.Text));
                            command.ExecuteNonQuery();
                            MessageBox.Show("Tao khach san thanh cong");
                            CreateHotelConvenience();
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateHotel();
            FHotelInformation fHotelInformation = new FHotelInformation(AdminID);
            (this.MdiParent as Admin)?.ShowForm(fHotelInformation);
        }
    }
}
