using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class UserMainForm : Form
    {
        FListRoom listRoom;
        public int hotelID;
        public UserMainForm()
        {
            InitializeComponent();
        }

        public void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            if (listRoom == null)
            {
                listRoom = new FListRoom(hotelID);
                listRoom.FormClosed += ListRoom_FormClosed;
                ShowForm(listRoom);
            }
            else
            {
                listRoom.Activate();
            }
        }

        private void ListRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            listRoom = null;
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            UserMainForm_Load(sender,e);
        }
    }
}
