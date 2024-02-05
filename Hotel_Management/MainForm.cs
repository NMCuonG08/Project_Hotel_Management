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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        RoomInformation roomInformation;
        FCustomerRegistration fCustomerRegistration;
        public void ShowForm(Form form)
        {

            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }

       


        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (roomInformation == null)
            {
                roomInformation = new RoomInformation();
                roomInformation.FormClosed += RoomInformation_FormClosed;
                ShowForm(roomInformation);
            }
            else
            {
                roomInformation.Activate();
            }
            
           
        }

        private void RoomInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            roomInformation = null;
        }

        private void main_transaction_Tick(object sender, EventArgs e)
        {

            if (mainTransaction == true)
            {

                panel_main.Width -= 10;

                if (panel_main.Width == panel_main.MinimumSize.Width)
                {
                    mainTransaction = false;
                    main_transaction.Stop();
                }
            }
            else
            {
                panel_main.Width += 10;
                if (panel_main.Width == panel_main.MaximumSize.Width)
                {
                    mainTransaction = true;
                    main_transaction.Stop();
                }
            }
        }
        #region
        private void ChangeButtonAndPanelHover(Button button, Panel panel)
        {
            button.BackColor = Color.LightBlue;
            button.ForeColor = Color.Black;
            panel.BackColor = Color.White;
        }
        private void ChangeButtonAndPanelLeave(Button button, Panel panel)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            panel.BackColor = Color.Black;
        }
        private void ChangeButtonAndPanelClick(Button button, Panel panel)
        {
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
            panel.BackColor = Color.White;
        }

        private void btn_Room_MouseHover(object sender, EventArgs e)
        {
            ChangeButtonAndPanelHover(btn_Room, panel_room);
        }
        private void btn_Room_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonAndPanelLeave(btn_Room, panel_room);
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            ChangeButtonAndPanelClick(btn_Room, panel_room);
            // Form1_Load(sender,e);
            Form1_Load(sender, e);

        }

        bool mainTransaction;

        private void btn_menu_Click(object sender, EventArgs e)
        {
            main_transaction.Start();
        }
        private void btn_registration_MouseHover(object sender, EventArgs e)
        {
            ChangeButtonAndPanelHover(btn_registration, panel_customer_reg);
        }

        private void btn_registration_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonAndPanelLeave(btn_registration, panel_customer_reg);
        }

        private void btn_registration_MouseClick(object sender, MouseEventArgs e)
        {
            ChangeButtonAndPanelClick(btn_registration, panel_customer_reg);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            ChangeButtonAndPanelClick(btn_checkout, panel_Checkout);
        }

        private void btn_checkout_MouseHover(object sender, EventArgs e)
        {
            ChangeButtonAndPanelHover(btn_checkout, panel_Checkout);
        }

        private void btn_checkout_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonAndPanelLeave(btn_checkout, panel_Checkout);
        }

        private void btn_cus_detail_Click(object sender, EventArgs e)
        {
            ChangeButtonAndPanelClick(btn_cus_detail, panel_cus_detal);
        }

        private void btn_cus_detail_MouseHover(object sender, EventArgs e)
        {
            ChangeButtonAndPanelHover(btn_cus_detail, panel_cus_detal);
        }

        private void btn_cus_detail_MouseLeave(object sender, EventArgs e)
        {
            ChangeButtonAndPanelLeave(btn_cus_detail, panel_cus_detal);
        }
        #endregion




        private void btn_registration_Click(object sender, EventArgs e)
        {
            if (fCustomerRegistration == null)
            {
                 fCustomerRegistration = new FCustomerRegistration();
                fCustomerRegistration.FormClosed += FCustomerRegistration_FormClosed;
                ShowForm(fCustomerRegistration);
            }
            else
            {
                fCustomerRegistration.Activate();
            }
            

        }

        private void FCustomerRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
           fCustomerRegistration = null;
        }

        private void addroom_t1_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
           
        }
       
        }
       
    
}
