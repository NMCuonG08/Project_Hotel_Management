using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class FRoomInformation : Form
    {
        SqlConnection conn = new
          SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        public FRoomInformation()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void SetData(Room room)
        {
            txb_roomid.Text = "No " + room.Id.ToString();
            txb_roomName.Text = room.Name;
            txb_roomBed.SelectedItem = room.Bed;
            txb_roomPrice.Text = room.Price.ToString();
            txb_roomtype.SelectedItem = room.Type;
            txb_clients.SelectedItem = room.Clients.ToString();
            txb_size.Text = room.Size.ToString();           
        }
        private void RoomInformation_Load(object sender, EventArgs e)
        {
          
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            FAddRoom fAddRoom = new FAddRoom();
             (this.MdiParent as Main)?.ShowForm(fAddRoom);

            //fAddRoom.Show();
        }

        private void RoomInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }
    }
}
