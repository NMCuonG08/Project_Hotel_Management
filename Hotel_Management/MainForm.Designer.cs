namespace Hotel_Management
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel_room = new System.Windows.Forms.Panel();
            this.btn_Room = new System.Windows.Forms.Button();
            this.panel_customer_reg = new System.Windows.Forms.Panel();
            this.btn_registration = new System.Windows.Forms.Button();
            this.panel_Checkout = new System.Windows.Forms.Panel();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.panel_cus_detal = new System.Windows.Forms.Panel();
            this.btn_cus_detail = new System.Windows.Forms.Button();
            this.main_transaction = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_home = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_room.SuspendLayout();
            this.panel_customer_reg.SuspendLayout();
            this.panel_Checkout.SuspendLayout();
            this.panel_cus_detal.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Controls.Add(this.panel_room);
            this.flowLayoutPanel2.Controls.Add(this.panel_customer_reg);
            this.flowLayoutPanel2.Controls.Add(this.panel_Checkout);
            this.flowLayoutPanel2.Controls.Add(this.panel_cus_detal);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1678, 113);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 101);
            this.panel1.TabIndex = 5;
            // 
            // btn_menu
            // 
            this.btn_menu.AutoSize = true;
            this.btn_menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_menu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_menu.Image = global::Hotel_Management.Properties.Resources.menu;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(-3, -9);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(212, 122);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "        ";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel_room
            // 
            this.panel_room.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_room.Controls.Add(this.btn_Room);
            this.panel_room.Location = new System.Drawing.Point(215, 3);
            this.panel_room.Name = "panel_room";
            this.panel_room.Size = new System.Drawing.Size(245, 109);
            this.panel_room.TabIndex = 3;
            // 
            // btn_Room
            // 
            this.btn_Room.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Room.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Room.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Room.Image = global::Hotel_Management.Properties.Resources.bed__1_;
            this.btn_Room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Room.Location = new System.Drawing.Point(-18, -9);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.btn_Room.Size = new System.Drawing.Size(278, 141);
            this.btn_Room.TabIndex = 2;
            this.btn_Room.Text = "Room";
            this.btn_Room.UseVisualStyleBackColor = false;
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            this.btn_Room.MouseLeave += new System.EventHandler(this.btn_Room_MouseLeave);
            this.btn_Room.MouseHover += new System.EventHandler(this.btn_Room_MouseHover);
            // 
            // panel_customer_reg
            // 
            this.panel_customer_reg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_customer_reg.Controls.Add(this.btn_registration);
            this.panel_customer_reg.Location = new System.Drawing.Point(466, 3);
            this.panel_customer_reg.Name = "panel_customer_reg";
            this.panel_customer_reg.Size = new System.Drawing.Size(392, 109);
            this.panel_customer_reg.TabIndex = 5;
            // 
            // btn_registration
            // 
            this.btn_registration.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_registration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_registration.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_registration.Image = global::Hotel_Management.Properties.Resources.queue;
            this.btn_registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registration.Location = new System.Drawing.Point(0, 0);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.btn_registration.Size = new System.Drawing.Size(392, 109);
            this.btn_registration.TabIndex = 2;
            this.btn_registration.Text = "     Customer Registration";
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_registration_MouseClick);
            this.btn_registration.MouseLeave += new System.EventHandler(this.btn_registration_MouseLeave);
            this.btn_registration.MouseHover += new System.EventHandler(this.btn_registration_MouseHover);
            // 
            // panel_Checkout
            // 
            this.panel_Checkout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Checkout.Controls.Add(this.btn_checkout);
            this.panel_Checkout.Location = new System.Drawing.Point(864, 3);
            this.panel_Checkout.Name = "panel_Checkout";
            this.panel_Checkout.Size = new System.Drawing.Size(304, 109);
            this.panel_Checkout.TabIndex = 6;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_checkout.Image = global::Hotel_Management.Properties.Resources.check_out;
            this.btn_checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checkout.Location = new System.Drawing.Point(0, 0);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.btn_checkout.Size = new System.Drawing.Size(304, 109);
            this.btn_checkout.TabIndex = 2;
            this.btn_checkout.Text = "Check Out";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            this.btn_checkout.MouseLeave += new System.EventHandler(this.btn_checkout_MouseLeave);
            this.btn_checkout.MouseHover += new System.EventHandler(this.btn_checkout_MouseHover);
            // 
            // panel_cus_detal
            // 
            this.panel_cus_detal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_cus_detal.Controls.Add(this.btn_cus_detail);
            this.panel_cus_detal.Location = new System.Drawing.Point(1174, 3);
            this.panel_cus_detal.Name = "panel_cus_detal";
            this.panel_cus_detal.Size = new System.Drawing.Size(350, 109);
            this.panel_cus_detal.TabIndex = 7;
            // 
            // btn_cus_detail
            // 
            this.btn_cus_detail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cus_detail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cus_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_cus_detail.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cus_detail.Image = global::Hotel_Management.Properties.Resources.satisfaction;
            this.btn_cus_detail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cus_detail.Location = new System.Drawing.Point(3, 3);
            this.btn_cus_detail.Name = "btn_cus_detail";
            this.btn_cus_detail.Padding = new System.Windows.Forms.Padding(30, 5, 5, 5);
            this.btn_cus_detail.Size = new System.Drawing.Size(350, 109);
            this.btn_cus_detail.TabIndex = 2;
            this.btn_cus_detail.Text = "Customer Details";
            this.btn_cus_detail.UseVisualStyleBackColor = false;
            this.btn_cus_detail.Click += new System.EventHandler(this.btn_cus_detail_Click);
            this.btn_cus_detail.MouseLeave += new System.EventHandler(this.btn_cus_detail_MouseLeave);
            this.btn_cus_detail.MouseHover += new System.EventHandler(this.btn_cus_detail_MouseHover);
            // 
            // main_transaction
            // 
            this.main_transaction.Interval = 10;
            this.main_transaction.Tick += new System.EventHandler(this.main_transaction_Tick);
            // 
            // panel_main
            // 
            this.panel_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_main.BackColor = System.Drawing.Color.Black;
            this.panel_main.Controls.Add(this.flowLayoutPanel4);
            this.panel_main.Controls.Add(this.flowLayoutPanel5);
            this.panel_main.Controls.Add(this.flowLayoutPanel6);
            this.panel_main.Controls.Add(this.flowLayoutPanel7);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 113);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.MaximumSize = new System.Drawing.Size(206, 900);
            this.panel_main.MinimumSize = new System.Drawing.Size(74, 900);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(74, 900);
            this.panel_main.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel4.Controls.Add(this.btn_home);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 69);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_home.Image = global::Hotel_Management.Properties.Resources._5402450_home_building_construction_house_property_icon;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(0, 0);
            this.btn_home.Margin = new System.Windows.Forms.Padding(0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(200, 73);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "        Home";
            this.btn_home.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 78);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(200, 62);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::Hotel_Management.Properties.Resources._274895_gear_settings_tools_machine_part_cog_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "          Settings";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel6.Controls.Add(this.button4);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 146);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(200, 62);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Image = global::Hotel_Management.Properties.Resources._211674_help_circled_icon__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 62);
            this.button4.TabIndex = 2;
            this.button4.Text = "      Help";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel7.Controls.Add(this.button5);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 214);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(200, 62);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Image = global::Hotel_Management.Properties.Resources._5402388_information_about_support_accessibility_info_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 62);
            this.button5.TabIndex = 2;
            this.button5.Text = "        About";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1678, 753);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_room.ResumeLayout(false);
            this.panel_customer_reg.ResumeLayout(false);
            this.panel_Checkout.ResumeLayout(false);
            this.panel_cus_detal.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel_room;
        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_customer_reg;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Panel panel_Checkout;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Panel panel_cus_detal;
        private System.Windows.Forms.Button btn_cus_detail;
        private System.Windows.Forms.Timer main_transaction;
        private System.Windows.Forms.FlowLayoutPanel panel_main;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button button5;
    }
}

