using Guna.UI2.WinForms;
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
        HotelInformationDAO hotelInformationDAO  = new HotelInformationDAO();
        public FHotelInformation(int adminID)
        {
            InitializeComponent();
            this.AdminID = adminID;
            if (hotelInformationDAO.CheckHotelExist(adminID))
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

       

        private void SetConveniences(int HotelID)
        {
            SqlDataReader reader = hotelInformationDAO.SetConveniences(HotelID);               
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

        private void setDataHotel()
        {
            HotelInformation hotel = hotelInformationDAO.GETHotelInformation(AdminID);
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
                txb_room.Text += hotelInformationDAO.SetCount(hotel).ToString();
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
          hotelInformationDAO.EditHotelConvenience(HotelID, checklistbox);
        }

        private void tbn_update_Click(object sender, EventArgs e)
        {
            int hotelID = Convert.ToInt32(txb_hotelID.Text);
            HotelInformation hotel = new HotelInformation
            {
                Id = hotelID,
                Name = txb_name.Text,
                City = txb_city.Text,
                Street = txb_street.Text,
                Score = float.Parse(txb_feedback.Text),
                Price = float.Parse(txb_price.Text),
                Email = txb_email.Text,
                Zipcode = txb_zip.Text,
                Floors = int.Parse(txb_floor.Text),
                Capacity = int.Parse(txb_capacity.Text),
                PhoneNumber = txb_phoneNumber.Text,
                Country = txb_country.Text,
                Description = txb_decription.Text
            };

            using (MemoryStream stream = new MemoryStream())
            {
                picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                hotel.HotelImage = stream.ToArray();
            }
            hotelInformationDAO.EditHotelConvenience(hotelID, checklistbox);
            hotelInformationDAO.UpdateHotel(hotel);
            messageHotel.Show("Update Successful!");
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
       
        private bool CheckDataEmpty()
        {
            if (string.IsNullOrEmpty(txb_capacity.Text) || string.IsNullOrEmpty(txb_city.Text) || string.IsNullOrEmpty(txb_country.Text) || string.IsNullOrEmpty(txb_capacity.Text) || string.IsNullOrEmpty(txb_feedback.Text) || string.IsNullOrEmpty(txb_floor.Text) || string.IsNullOrEmpty(txb_email.Text) || string.IsNullOrEmpty(txb_price.Text) || string.IsNullOrEmpty(txb_phoneNumber.Text) || string.IsNullOrEmpty(txb_room.Text) || picturebox.Image == null)
            {
                return false;
            }
            return true;
        }

       
        private void btn_create_Click(object sender, EventArgs e)
        {
           if (CheckDataEmpty())
            {
                HotelInformation hotel = new HotelInformation
                {
                    Name = txb_name.Text,
                    City = txb_city.Text,
                    Street = txb_street.Text,
                    Score = float.Parse(txb_feedback.Text),
                    Price = float.Parse(txb_price.Text),
                    Email = txb_email.Text,
                    Zipcode = txb_zip.Text,
                    Floors = int.Parse(txb_floor.Text),
                    Capacity = int.Parse(txb_capacity.Text),
                    PhoneNumber = txb_phoneNumber.Text,
                    Country = txb_country.Text,
                    Description = txb_decription.Text
                };
                using (MemoryStream stream = new MemoryStream())
                {
                    picturebox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    hotel.HotelImage = stream.ToArray();
                }
                hotelInformationDAO.CreateHotel(hotel, AdminID);
                hotelInformationDAO.CreateHotelConvenience(checklistbox);
                FHotelInformation fHotelInformation = new FHotelInformation(AdminID);
                (this.MdiParent as Admin)?.ShowForm(fHotelInformation);
            }
           else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void txb_capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txb_floor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_feedback_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
    }
}
