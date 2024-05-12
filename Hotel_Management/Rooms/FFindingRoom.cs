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
       HotelInformationDAO hotelInformationDAO = new HotelInformationDAO();
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
                DataTable data = hotelInformationDAO.LoadHotel();              
                gv_hotel.DataSource = data;
                createItem(data);
            HashSet<string> uniqueHotel = hotelInformationDAO.GetUniqueHotelLocation();
            cbx_hotelLocation.DataSource = new BindingSource(uniqueHotel, null);  
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
                    if (hotelInformationDAO.SetRating(ls[i].Id) != null)
                    {
                        ls[i].Point = hotelInformationDAO.SetRating(ls[i].Id);
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
            choiceRoom.ShowDialog();          
        }

        private void btn_findinghotel_Click(object sender, EventArgs e)
        {
            string selectedLocation = cbx_hotelLocation.Text.Trim();
            DataTable data = hotelInformationDAO.FindingHotel(selectedLocation, checkedListBox_convenience);
            flowpanel.Controls.Clear();
            createItem(data);
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private List<String> CheckConvenience(int hotelID)
        {
            List<string> convenienceNames = new List<string>();
            SqlDataReader reader = hotelInformationDAO.CheckConveniences(hotelID);
                    while (reader.Read())
                    {
                        string columnName = reader["COLUMN_NAME"].ToString();
                        convenienceNames.Add(columnName);
                    }
                    reader.Close();
            return convenienceNames;
        }

        private void btn_lowprice_Click(object sender, EventArgs e)
        {           
            flowpanel.Controls.Clear();
            DataTable data = hotelInformationDAO.OrderPice("Price","");
            gv_hotel.DataSource = data;
            createItem(data);           
        }

        private void btn_highprice_Click(object sender, EventArgs e)
        {
            flowpanel.Controls.Clear();
            DataTable data = hotelInformationDAO.OrderPice("Price","DESC");
            gv_hotel.DataSource = data;
            createItem(data);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            flowpanel.Controls.Clear();
            LoadForm();
            
        }

        private void btn_feed_Click(object sender, EventArgs e)
        {
            flowpanel.Controls.Clear();
            DataTable data = hotelInformationDAO.OrderPice("FeedBack", "DESC");
            gv_hotel.DataSource = data;
            createItem(data);
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
            flowpanel.Controls.Clear();
            DataTable data = hotelInformationDAO.OrderValue("Feedback", min, max);
            gv_hotel.DataSource = data;
            createItem(data);
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

            flowpanel.Controls.Clear();
            int minValue;
            int maxValue = 0;

            if (int.TryParse(txb_minvalue.Text, out minValue))
            {
                if (!string.IsNullOrEmpty(txb_maxvalue.Text))
                {
                    maxValue = int.Parse(txb_maxvalue.Text);
                }
                DataTable data = hotelInformationDAO.OrderValue("Price",maxValue,minValue);
                gv_hotel.DataSource = data;
                createItem(data);
            }
        }

        private void txb_maxvalue_TextChanged(object sender, EventArgs e)
        {
            txb_minvalue_TextChanged(sender, e);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void processbar_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}
