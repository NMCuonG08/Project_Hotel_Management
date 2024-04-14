using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FEvaluate : Form
    {
        int HotelID;
        int RoomID;
        int UserID;
        double Price= 0;
        public FEvaluate(int hotelID,int roomID, int userID, double price)
        {
            InitializeComponent();
            HotelID = hotelID;
            RoomID = roomID;
            UserID = userID;
            Price = price;
            Room room = Instance.GetRoomByID(roomID);
            Account user = Instance.GetUserByID(userID);
            HotelInformation hotelInformation = Instance.GetHotelInformationByID(hotelID);
            SetData(room,user,hotelInformation);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetData(Room Room, Account User, HotelInformation HotelInformation)
        {

            if (HotelInformation != null)
            {
                lb_hotelname.Text = HotelInformation.Name ?? string.Empty;
                if (HotelInformation.HotelImage != null)
                {
                    byte[] image = HotelInformation.HotelImage;
                    using (MemoryStream ms = new MemoryStream(image))
                    {
                        picturebox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }

            if (Room != null)
            {
                lb_roomtype.Text = Room.Type ?? string.Empty;
                lb_bed.Text = Room.Bed ?? string.Empty;
                lb_roomsize.Text = Room.Size.ToString() + " m2";
                lb_clients.Text = Room.Clients.ToString() + " clients";
                lb_price.Text = Price.ToString() + " $";
            }
        }

        private void Submit()
        {
            double rate = (rating_food.Value + rating_location.Value+ rating_sachse.Value + rating_service.Value + rating_thoaimai.Value )/2.5;
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string query = "Insert into Evaluate values (@rate, @comment, @hotelID, @userID, @date)";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    sqlCommand.Parameters.Add("rate", rate);
                    sqlCommand.Parameters.Add("comment", txb_comment.Text);
                    sqlCommand.Parameters.Add("hotelID", HotelID);
                    sqlCommand.Parameters.Add("userID", UserID);
                    sqlCommand.Parameters.Add("@date", DateTime.Now);
                    sqlCommand.ExecuteNonQuery();
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Submit();
            message.Show("Cảm ơn vì đánh giá của bạn!<3", "Thông báo");
            this.Close();
        }
    }
}
