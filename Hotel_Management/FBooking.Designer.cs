namespace Hotel_Management
{
    partial class FBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gvBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bookingstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txb_cus_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txb_customer_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_addRoom = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bookings";
            // 
            // gvBooking
            // 
            this.gvBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.gvBooking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gvBooking.ColumnHeadersHeight = 37;
            this.gvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingNumber,
            this.CusName,
            this.Checkin,
            this.Checkout,
            this.BookingDate,
            this.PaymentStatus,
            this.Bookingstatus});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBooking.DefaultCellStyle = dataGridViewCellStyle32;
            this.gvBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvBooking.Location = new System.Drawing.Point(55, 444);
            this.gvBooking.Name = "gvBooking";
            this.gvBooking.ReadOnly = true;
            this.gvBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.gvBooking.RowHeadersVisible = false;
            this.gvBooking.RowHeadersWidth = 51;
            this.gvBooking.RowTemplate.Height = 32;
            this.gvBooking.Size = new System.Drawing.Size(1651, 545);
            this.gvBooking.TabIndex = 4;
            this.gvBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvBooking.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvBooking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gvBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvBooking.ThemeStyle.HeaderStyle.Height = 37;
            this.gvBooking.ThemeStyle.ReadOnly = true;
            this.gvBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvBooking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gvBooking.ThemeStyle.RowsStyle.Height = 32;
            this.gvBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gvBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvBooking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBooking_CellContentClick);
            // 
            // BookingNumber
            // 
            this.BookingNumber.DataPropertyName = "ID";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.BookingNumber.DefaultCellStyle = dataGridViewCellStyle25;
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.MinimumWidth = 6;
            this.BookingNumber.Name = "BookingNumber";
            this.BookingNumber.ReadOnly = true;
            // 
            // CusName
            // 
            this.CusName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.CusName.DefaultCellStyle = dataGridViewCellStyle26;
            this.CusName.HeaderText = "Customer Name";
            this.CusName.MinimumWidth = 6;
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.DataPropertyName = "CheckIn";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Checkin.DefaultCellStyle = dataGridViewCellStyle27;
            this.Checkin.HeaderText = "Check in";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.DataPropertyName = "CheckOut";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Checkout.DefaultCellStyle = dataGridViewCellStyle28;
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.MinimumWidth = 6;
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // BookingDate
            // 
            this.BookingDate.DataPropertyName = "BookingDate";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.BookingDate.DefaultCellStyle = dataGridViewCellStyle29;
            this.BookingDate.HeaderText = "Booking Date";
            this.BookingDate.MinimumWidth = 6;
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.PaymentStatus.DefaultCellStyle = dataGridViewCellStyle30;
            this.PaymentStatus.HeaderText = "Payment Status";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // Bookingstatus
            // 
            this.Bookingstatus.DataPropertyName = "BookingStatus";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Bookingstatus.DefaultCellStyle = dataGridViewCellStyle31;
            this.Bookingstatus.HeaderText = "Booking Status";
            this.Bookingstatus.MinimumWidth = 6;
            this.Bookingstatus.Name = "Bookingstatus";
            this.Bookingstatus.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.guna2DateTimePicker2);
            this.panel1.Controls.Add(this.guna2DateTimePicker1);
            this.panel1.Controls.Add(this.datetime_from);
            this.panel1.Location = new System.Drawing.Point(55, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1651, 263);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1089, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Booking Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Check out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(178, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Check in";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.Animated = true;
            this.guna2DateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(762, 22);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(306, 41);
            this.guna2DateTimePicker2.TabIndex = 14;
            this.guna2DateTimePicker2.UseTransparentBackground = true;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 3, 8, 9, 42, 26, 9);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(1241, 22);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(306, 41);
            this.guna2DateTimePicker1.TabIndex = 13;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 3, 8, 9, 42, 26, 9);
            // 
            // datetime_from
            // 
            this.datetime_from.Animated = true;
            this.datetime_from.BackColor = System.Drawing.Color.Transparent;
            this.datetime_from.Checked = true;
            this.datetime_from.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_from.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_from.Location = new System.Drawing.Point(284, 22);
            this.datetime_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_from.Name = "datetime_from";
            this.datetime_from.Size = new System.Drawing.Size(306, 41);
            this.datetime_from.TabIndex = 12;
            this.datetime_from.UseTransparentBackground = true;
            this.datetime_from.Value = new System.DateTime(2024, 3, 8, 9, 42, 26, 9);
            // 
            // txb_cus_name
            // 
            this.txb_cus_name.BorderColor = System.Drawing.Color.Black;
            this.txb_cus_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_cus_name.DefaultText = "";
            this.txb_cus_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_cus_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_cus_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cus_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_cus_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cus_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_cus_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_cus_name.Location = new System.Drawing.Point(1846, 491);
            this.txb_cus_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_cus_name.Name = "txb_cus_name";
            this.txb_cus_name.PasswordChar = '\0';
            this.txb_cus_name.PlaceholderText = "Customer Name";
            this.txb_cus_name.SelectedText = "";
            this.txb_cus_name.Size = new System.Drawing.Size(286, 55);
            this.txb_cus_name.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(1387, 402);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 25);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search:";
            // 
            // txb_customer_name
            // 
            this.txb_customer_name.BorderColor = System.Drawing.Color.DarkGray;
            this.txb_customer_name.BorderRadius = 5;
            this.txb_customer_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_customer_name.DefaultText = "";
            this.txb_customer_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_customer_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_customer_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_customer_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_customer_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_customer_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txb_customer_name.ForeColor = System.Drawing.Color.Black;
            this.txb_customer_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_customer_name.Location = new System.Drawing.Point(1477, 389);
            this.txb_customer_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_customer_name.Name = "txb_customer_name";
            this.txb_customer_name.PasswordChar = '\0';
            this.txb_customer_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txb_customer_name.PlaceholderText = "Customer Name";
            this.txb_customer_name.SelectedText = "";
            this.txb_customer_name.Size = new System.Drawing.Size(229, 48);
            this.txb_customer_name.TabIndex = 17;
            // 
            // Btn_addRoom
            // 
            this.Btn_addRoom.BackgroundImage = global::Hotel_Management.Properties.Resources.Add___Copy;
            this.Btn_addRoom.BorderRadius = 10;
            this.Btn_addRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_addRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_addRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_addRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_addRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(116)))), ((int)(((byte)(16)))));
            this.Btn_addRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Btn_addRoom.ForeColor = System.Drawing.Color.White;
            this.Btn_addRoom.Image = global::Hotel_Management.Properties.Resources.plus__1_;
            this.Btn_addRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_addRoom.Location = new System.Drawing.Point(1597, 54);
            this.Btn_addRoom.Name = "Btn_addRoom";
            this.Btn_addRoom.Size = new System.Drawing.Size(109, 45);
            this.Btn_addRoom.TabIndex = 18;
            this.Btn_addRoom.Text = "      Add  ";
            this.Btn_addRoom.Click += new System.EventHandler(this.Btn_addRoom_Click);
            // 
            // FBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1775, 1008);
            this.Controls.Add(this.Btn_addRoom);
            this.Controls.Add(this.txb_customer_name);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txb_cus_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvBooking);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBooking";
            this.Text = "FBooking";
            ((System.ComponentModel.ISupportInitialize)(this.gvBooking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView gvBooking;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txb_cus_name;
        private System.Windows.Forms.Label Search;
        private Guna.UI2.WinForms.Guna2TextBox txb_customer_name;
        private Guna.UI2.WinForms.Guna2Button Btn_addRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookingstatus;
    }
}