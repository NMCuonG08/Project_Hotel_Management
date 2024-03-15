namespace Hotel_Management
{
    partial class UCListRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCListRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_Checkin = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txb_checkout = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctbox = new System.Windows.Forms.PictureBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Booking = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room:";
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_name.Location = new System.Drawing.Point(356, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(102, 37);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "name";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_status
            // 
            this.lb_status.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_status.Location = new System.Drawing.Point(270, 40);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(153, 37);
            this.lb_status.TabIndex = 3;
            this.lb_status.Text = "status";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel_Management.Properties.Resources.shedule_checkin___Copy___Copy;
            this.panel2.Location = new System.Drawing.Point(464, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 18);
            this.panel2.TabIndex = 5;
            // 
            // txb_Checkin
            // 
            this.txb_Checkin.BorderRadius = 10;
            this.txb_Checkin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_Checkin.DefaultText = "";
            this.txb_Checkin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_Checkin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_Checkin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Checkin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_Checkin.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.txb_Checkin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Checkin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_Checkin.ForeColor = System.Drawing.Color.White;
            this.txb_Checkin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_Checkin.Location = new System.Drawing.Point(488, 2);
            this.txb_Checkin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_Checkin.Name = "txb_Checkin";
            this.txb_Checkin.PasswordChar = '\0';
            this.txb_Checkin.PlaceholderText = "";
            this.txb_Checkin.ReadOnly = true;
            this.txb_Checkin.SelectedText = "";
            this.txb_Checkin.Size = new System.Drawing.Size(256, 33);
            this.txb_Checkin.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Hotel_Management.Properties.Resources.schedule_checkout___Copy___Copy;
            this.panel5.Location = new System.Drawing.Point(464, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 19);
            this.panel5.TabIndex = 6;
            // 
            // txb_checkout
            // 
            this.txb_checkout.BorderRadius = 10;
            this.txb_checkout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_checkout.DefaultText = "";
            this.txb_checkout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_checkout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_checkout.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.txb_checkout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_checkout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_checkout.ForeColor = System.Drawing.Color.White;
            this.txb_checkout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_checkout.Location = new System.Drawing.Point(488, 45);
            this.txb_checkout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_checkout.Name = "txb_checkout";
            this.txb_checkout.PasswordChar = '\0';
            this.txb_checkout.PlaceholderText = "";
            this.txb_checkout.ReadOnly = true;
            this.txb_checkout.SelectedText = "";
            this.txb_checkout.Size = new System.Drawing.Size(256, 32);
            this.txb_checkout.TabIndex = 11;
            // 
            // txb_price
            // 
            this.txb_price.BorderRadius = 10;
            this.txb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_price.DefaultText = "";
            this.txb_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_price.FillColor = System.Drawing.Color.DarkKhaki;
            this.txb_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txb_price.ForeColor = System.Drawing.Color.Black;
            this.txb_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_price.Location = new System.Drawing.Point(705, 115);
            this.txb_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_price.Name = "txb_price";
            this.txb_price.PasswordChar = '\0';
            this.txb_price.PlaceholderText = "";
            this.txb_price.ReadOnly = true;
            this.txb_price.SelectedText = "";
            this.txb_price.Size = new System.Drawing.Size(155, 45);
            this.txb_price.TabIndex = 12;
            this.txb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(631, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price";
            // 
            // pctbox
            // 
            this.pctbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pctbox.Location = new System.Drawing.Point(0, 0);
            this.pctbox.Name = "pctbox";
            this.pctbox.Size = new System.Drawing.Size(259, 165);
            this.pctbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbox.TabIndex = 0;
            this.pctbox.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_delete.ImageRotate = 0F;
            this.btn_delete.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_delete.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btn_delete.Location = new System.Drawing.Point(820, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_delete.Size = new System.Drawing.Size(44, 40);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.TextFormatNoPrefix = true;
            // 
            // btn_Booking
            // 
            this.btn_Booking.BorderRadius = 10;
            this.btn_Booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Booking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Booking.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Booking.ForeColor = System.Drawing.Color.Black;
            this.btn_Booking.Location = new System.Drawing.Point(350, 115);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(180, 45);
            this.btn_Booking.TabIndex = 26;
            this.btn_Booking.Text = "Booking";
            this.btn_Booking.Visible = false;
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // UCListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn_Booking);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pctbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_price);
            this.Controls.Add(this.txb_checkout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.txb_Checkin);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_name);
            this.Name = "UCListRoom";
            this.Size = new System.Drawing.Size(864, 165);
            this.Load += new System.EventHandler(this.UCListRoom_Load);
            this.Click += new System.EventHandler(this.UCListRoom_Click);
            this.MouseEnter += new System.EventHandler(this.UCListRoom_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UCListRoom_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txb_Checkin;
        private Guna.UI2.WinForms.Guna2TextBox txb_checkout;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctbox;
        private Guna.UI2.WinForms.Guna2ImageButton btn_delete;
        public Guna.UI2.WinForms.Guna2Button btn_Booking;
    }
}
