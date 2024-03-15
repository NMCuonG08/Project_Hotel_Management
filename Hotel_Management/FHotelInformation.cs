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
    public partial class FHotelInformation : Form
    {

        public int AdminID { get; set; }

        public FHotelInformation(int adminID)
        {
            InitializeComponent();
            this.AdminID = adminID;
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

        private void setDataHotel()
        {
            HotelInformation hotel = ReadData(AdminID);
            if (hotel != null)
            {
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

        private void tbn_update_Click(object sender, EventArgs e)
        {

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
    }
}
