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
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management
{
    public partial class FAddRoom : Form, IHotelIDConsumer
    {
        public int HotelID { get; set; }


        public FAddRoom(int hotelID)
        {
            InitializeComponent();
            txb_roomname.Focus();
            this.HotelID = hotelID;   
        }
        SqlConnection conn = new
          SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");

        private void txb_roomNum_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            { 
                txb_roomtype.Focus();  
            }
        }

        private void txb_roomPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }
        string imageLocation = "";
        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files (*.png)|*png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.* ";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName.ToString();
                picturebox.ImageLocation = imageLocation;
            }
        }

        

       /* private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = "Select htImage from HotelImage where id = '" + txb_id.Text + "' ";

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn); 
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);
                        if (img == null) {
                            picturebox.Image = null;
                        }
                        else
                        {
                            MemoryStream imageStream = new MemoryStream(img);
                            picturebox.Image = Image.FromStream(imageStream);

                        }

                    }
                    else
                    {
                       
                        MessageBox.Show("Not exist");
                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }*/

        private void btn_clear_Click(object sender, EventArgs e)
        {
            picturebox.Image = null ;
        }


        void rBtnCheckAll(RadioButton rbtn, CheckedListBox checkedList )
        {
            if (rbtn.Checked)
            {
                for (int i = 0; i < checkedList.Items.Count; i++)
                {
                    checkedList.SetItemChecked(i, true);
                }
            }
        }
        void rBtn_ClearAll(RadioButton rbtn, CheckedListBox checkedList)
        {
            if (rbtn.Checked)
            {
                for (int i = 0; i < checkedList.Items.Count; i++)
                {
                    checkedList.SetItemChecked(i, false);
                }
            }
        }


        private void radio_btn_checkall_CheckedChanged(object sender, EventArgs e)
        {
            rBtnCheckAll(radio_btn_checkall, checklistbox);
        }

        private void radio_btn_clear_CheckedChanged(object sender, EventArgs e)
        {
            rBtn_ClearAll(radio_btn_clear, checklistbox);
        }

        private void rbtn_choiceall_CheckedChanged(object sender, EventArgs e)
        {
            rBtnCheckAll(rbtn_choiceall, checklistbathroom);    
        }

        private void rbtn_clearall_CheckedChanged(object sender, EventArgs e)
        {
            rBtn_ClearAll(rbtn_clearall, checklistbathroom);
        }

        private void FAddRoom_Load(object sender, EventArgs e)
        {

        }
        /*private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(stream);
                images = br.ReadBytes((int)stream.Length);

                conn.Open();
                string sql = "Insert into HotelImage(htImage) values( @images )";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                sqlCommand.Parameters.Add(new SqlParameter("@images", images));
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Upload successful");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
*/

        public delegate void AddRoomDelegate(Room room);
        public AddRoomDelegate addRoom;

        public void SetConveniences(CheckedListBox checkedListBox)
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    int maxRoomID;
                    string getMaxRoomIDQuery = "SELECT MAX(RoomID) FROM RoomInformation";
                    using (SqlCommand getMaxRoomIDCmd = new SqlCommand(getMaxRoomIDQuery, connection))
                    {
                        object result = getMaxRoomIDCmd.ExecuteScalar();
                        maxRoomID = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                    int newRoomID = maxRoomID ;

                    string addRoomConvenienceQuery = "INSERT INTO RoomConveniences (RoomiD) VALUES (@RoomID)";
                    using (SqlCommand addRoomConvenienceCmd = new SqlCommand(addRoomConvenienceQuery, connection))
                    {
                        addRoomConvenienceCmd.Parameters.AddWithValue("@RoomID", newRoomID);
                        addRoomConvenienceCmd.ExecuteNonQuery();
                    }
                    string addBathRoomConvenienceQuery = "INSERT INTO Bathroomconveniences (RoomiD) VALUES (@RoomID)";
                    using (SqlCommand addBathRoomConvenienceCmd = new SqlCommand(addBathRoomConvenienceQuery, connection))
                    {
                        addBathRoomConvenienceCmd.Parameters.AddWithValue("@RoomID", newRoomID);
                        addBathRoomConvenienceCmd.ExecuteNonQuery();
                    }

                    foreach (object itemChecked in checkedListBox.CheckedItems)
                    {
                        string updateQuery = "UPDATE RoomConveniences SET ";
                        string itemName = itemChecked.ToString();
                        updateQuery += $"{itemName} = 1 WHERE RoomID = @RoomID"; 

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@RoomID", newRoomID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    foreach (object itemChecked in checklistbathroom.CheckedItems)
                    {
                        string updateQuery = "UPDATE Bathroomconveniences SET ";
                        string itemName = itemChecked.ToString();
                        updateQuery += $"{itemName} = 1 WHERE RoomID = @RoomID";

                        // Thực hiện truy vấn SQL
                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@RoomID", newRoomID);
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


        private void btn_add_Click(object sender, EventArgs e)
        {
            
            byte[] images = null;
            FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);

            string status = "empty"; conn.Open();
            int roomPrice = Convert.ToInt32(txb_price.Text);
            int clients = Convert.ToInt32(txb_clients.Text);
            int size = Convert.ToInt32(txb_size.Text);
            Room room = new Room(txb_roomname.Text, txb_roomtype.Text, txb_bed.Text, clients, size, roomPrice, null, null, images, status);
            addRoom(room);
            SetConveniences(checklistbox);
            Connection.Openadmin();
            this.Close();
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
