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
       
        int hotelID ;
        string imageLocation = "";
        RoomDAO roomDAO = new RoomDAO();
        public FRoomInformation()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        public void SetData(Room room)
        {
            txb_roomid.Text =  room.Id.ToString();
            txb_roomname.Text = room.Name;
            txb_bed.SelectedItem = room.Bed;
            txb_price.Text = room.Price.ToString();
            txb_roomtype.SelectedItem = room.Type;
            txb_clients.SelectedItem = room.Clients.ToString();
            txb_size.Text = room.Size.ToString();      
            combobox_status.Text = room.Status.ToString();
            byte[] image = room.Image;
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream(image))
                {
                    string temporaryImagePath = Path.Combine(Path.GetTempPath(), "tempImage.png");
                    using (FileStream fs = new FileStream(temporaryImagePath, FileMode.Create))
                    {
                        ms.CopyTo(fs);
                    }
                    imageLocation = temporaryImagePath;
                    picturebox.Image = System.Drawing.Image.FromStream(ms);
                }
            }
            SetConveniences(room.Id);
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
            
        }
       
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
        public void SetConveniences( int RoomID)
        {
            SqlDataReader reader = roomDAO.SetConveniences(RoomID);
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
                SqlDataReader reader2 = roomDAO.SetBathroomconveniences(RoomID);
                
                    if (reader2.Read())
                    {
                        for (int i = 1; i < reader2.FieldCount; i++)
                        {
                            string columnName = reader2.GetName(i);
                            bool value = Convert.ToBoolean(reader2[columnName]);
                            if (value)
                            {
                                int index = checklistbathroom.Items.IndexOf(columnName);
                                if (index != -1)
                                {
                                    checklistbathroom.SetItemChecked(index, true);
                                }
                            }
                        }
                    }
        }
       
        public delegate void EditRoomDelegate(Room room);
        public EditRoomDelegate editRoom;
        private void btn_complete_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            if (!string.IsNullOrEmpty(imageLocation))
            {
                using (FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        image = br.ReadBytes((int)fs.Length);
                    }
                }
            }
            int roomPrice = Convert.ToInt32(txb_price.Text);
            int roomID = Convert.ToInt32(txb_roomid.Text);
            int clients = Convert.ToInt32(txb_clients.Text);
            int size = Convert.ToInt32(txb_size.Text);
            if (!string.IsNullOrEmpty(txb_price.Text) && int.TryParse(txb_price.Text, out roomPrice) &&
                !string.IsNullOrEmpty(txb_roomid.Text) && int.TryParse(txb_roomid.Text, out roomID) &&
                !string.IsNullOrEmpty(txb_clients.Text) && int.TryParse(txb_clients.Text, out clients) &&
                !string.IsNullOrEmpty(txb_size.Text) && int.TryParse(txb_size.Text, out size))
            {
                Room room = new Room(roomID, txb_roomname.Text, txb_roomtype.Text, txb_bed.Text, clients, size, roomPrice, combobox_status.Text, image);
                editRoom(room);
                roomDAO.EditConveniences(roomID,checklistbox,checklistbathroom);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields with valid integer values.");
            }
           
        }
    }
}
