﻿namespace Hotel_Management
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.main_transaction = new System.Windows.Forms.Timer(this.components);
            this.panel_main = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_menu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_hotel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_room = new Guna.UI2.WinForms.Guna2Button();
            this.btn_booking = new Guna.UI2.WinForms.Guna2Button();
            this.btn_checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_feedback = new Guna.UI2.WinForms.Guna2Button();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2GradientTileButton10 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_static = new Guna.UI2.WinForms.Guna2Button();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_transaction
            // 
            this.main_transaction.Interval = 10;
            this.main_transaction.Tick += new System.EventHandler(this.main_transaction_Tick);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_main.Controls.Add(this.btn_menu);
            this.panel_main.Controls.Add(this.btn_hotel);
            this.panel_main.Controls.Add(this.btn_room);
            this.panel_main.Controls.Add(this.btn_booking);
            this.panel_main.Controls.Add(this.btn_checkout);
            this.panel_main.Controls.Add(this.btn_feedback);
            this.panel_main.Controls.Add(this.btn_static);
            this.panel_main.Controls.Add(this.btn_logout);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.MaximumSize = new System.Drawing.Size(250, 1055);
            this.panel_main.MinimumSize = new System.Drawing.Size(100, 1055);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(250, 1055);
            this.panel_main.TabIndex = 6;
            // 
            // btn_menu
            // 
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = global::Hotel_Management.Properties.Resources.menu__1_;
            this.btn_menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_menu.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_menu.ImageSize = new System.Drawing.Size(33, 33);
            this.btn_menu.Location = new System.Drawing.Point(3, 3);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(243, 116);
            this.btn_menu.TabIndex = 20;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_hotel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hotel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hotel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hotel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hotel.FillColor = System.Drawing.Color.Transparent;
            this.btn_hotel.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Image = global::Hotel_Management.Properties.Resources.hotel__6_;
            this.btn_hotel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_hotel.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_hotel.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_hotel.Location = new System.Drawing.Point(3, 125);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(243, 88);
            this.btn_hotel.TabIndex = 14;
            this.btn_hotel.Text = "     Hotel";
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_room.FillColor = System.Drawing.Color.Transparent;
            this.btn_room.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_room.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_room.ForeColor = System.Drawing.Color.Black;
            this.btn_room.Image = global::Hotel_Management.Properties.Resources.bed__4_;
            this.btn_room.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_room.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_room.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_room.Location = new System.Drawing.Point(3, 219);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(243, 88);
            this.btn_room.TabIndex = 15;
            this.btn_room.Text = "       Rooms";
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_booking
            // 
            this.btn_booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_booking.FillColor = System.Drawing.Color.Transparent;
            this.btn_booking.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.Color.White;
            this.btn_booking.Image = global::Hotel_Management.Properties.Resources.booking__2_;
            this.btn_booking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_booking.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_booking.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_booking.Location = new System.Drawing.Point(3, 313);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.Size = new System.Drawing.Size(243, 88);
            this.btn_booking.TabIndex = 16;
            this.btn_booking.Text = "         Booking";
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_checkout.FillColor = System.Drawing.Color.Transparent;
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Image = global::Hotel_Management.Properties.Resources._7324058_ui_interface_check_out_calendar_schedule_icon__1_;
            this.btn_checkout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_checkout.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_checkout.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_checkout.Location = new System.Drawing.Point(3, 407);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(243, 88);
            this.btn_checkout.TabIndex = 17;
            this.btn_checkout.Text = "           Checkout";
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_feedback
            // 
            this.btn_feedback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_feedback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_feedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_feedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_feedback.FillColor = System.Drawing.Color.Transparent;
            this.btn_feedback.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_feedback.ForeColor = System.Drawing.Color.White;
            this.btn_feedback.Image = global::Hotel_Management.Properties.Resources.chat;
            this.btn_feedback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_feedback.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_feedback.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_feedback.Location = new System.Drawing.Point(3, 501);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(243, 88);
            this.btn_feedback.TabIndex = 21;
            this.btn_feedback.Text = "           Feedback";
            this.btn_feedback.Click += new System.EventHandler(this.btn_feedback_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_logout.FillColor = System.Drawing.Color.Transparent;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Image = global::Hotel_Management.Properties.Resources.log_out;
            this.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_logout.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_logout.Location = new System.Drawing.Point(3, 689);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(243, 88);
            this.btn_logout.TabIndex = 19;
            this.btn_logout.Text = "       Log out";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1532, 46);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.guna2GradientTileButton10);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1255, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 46);
            this.panel4.TabIndex = 12;
            // 
            // guna2GradientTileButton10
            // 
            this.guna2GradientTileButton10.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton10.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.guna2GradientTileButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton10.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton10.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton10.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton10.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton10.Image = global::Hotel_Management.Properties.Resources.admin;
            this.guna2GradientTileButton10.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientTileButton10.Location = new System.Drawing.Point(3, 0);
            this.guna2GradientTileButton10.Name = "guna2GradientTileButton10";
            this.guna2GradientTileButton10.Size = new System.Drawing.Size(65, 41);
            this.guna2GradientTileButton10.TabIndex = 119;
            this.guna2GradientTileButton10.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(191, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome: admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // btn_static
            // 
            this.btn_static.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_static.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_static.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_static.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_static.FillColor = System.Drawing.Color.Transparent;
            this.btn_static.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_static.ForeColor = System.Drawing.Color.White;
            this.btn_static.Image = global::Hotel_Management.Properties.Resources.statistic;
            this.btn_static.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_static.ImageOffset = new System.Drawing.Point(15, 0);
            this.btn_static.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_static.Location = new System.Drawing.Point(3, 595);
            this.btn_static.Name = "btn_static";
            this.btn_static.Size = new System.Drawing.Size(243, 88);
            this.btn_static.TabIndex = 22;
            this.btn_static.Text = "         Statistic";
            this.btn_static.Click += new System.EventHandler(this.btn_static_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer main_transaction;
        private System.Windows.Forms.FlowLayoutPanel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        public Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton10;
        private Guna.UI2.WinForms.Guna2Button btn_hotel;
        private Guna.UI2.WinForms.Guna2Button btn_room;
        private Guna.UI2.WinForms.Guna2Button btn_booking;
        private Guna.UI2.WinForms.Guna2Button btn_checkout;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Button btn_menu;
        private Guna.UI2.WinForms.Guna2Button btn_feedback;
        private Guna.UI2.WinForms.Guna2Button btn_static;
    }
}