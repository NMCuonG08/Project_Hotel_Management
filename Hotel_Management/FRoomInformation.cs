﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Hotel_Management
{
    public partial class FRoomInformation : Form
    {
        SqlConnection conn = new
          SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        int hotelID ;
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
            byte[] image = room.Image;
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    picturebox.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }
        private void RoomInformation_Load(object sender, EventArgs e)
        {
          
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            FAddRoom fAddRoom = new FAddRoom(hotelID);
             (this.MdiParent as Admin)?.ShowForm(fAddRoom);

            //fAddRoom.Show();
        }

        private void RoomInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
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

        private void btn_add_Click_1(object sender, EventArgs e)
        {

        }
        void rBtnCheckAll(RadioButton rbtn, CheckedListBox checkedList)
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
