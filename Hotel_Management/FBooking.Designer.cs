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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txb_cus_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.txb_customer_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_addRoom = new Guna.UI2.WinForms.Guna2Button();
            this.label28 = new System.Windows.Forms.Label();
            this.combx_paymentstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.combx_Bookingstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bookings";
            // 
            // gvBooking
            // 
            this.gvBooking.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            this.gvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
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
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBooking.DefaultCellStyle = dataGridViewCellStyle43;
            this.gvBooking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvBooking.Location = new System.Drawing.Point(55, 398);
            this.gvBooking.Name = "gvBooking";
            this.gvBooking.ReadOnly = true;
            this.gvBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.gvBooking.RowHeadersVisible = false;
            this.gvBooking.RowHeadersWidth = 51;
            this.gvBooking.RowTemplate.Height = 32;
            this.gvBooking.Size = new System.Drawing.Size(1651, 591);
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
            this.gvBooking.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.gvBooking_RowPrePaint);
            // 
            // BookingNumber
            // 
            this.BookingNumber.DataPropertyName = "ID";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.BookingNumber.DefaultCellStyle = dataGridViewCellStyle36;
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.MinimumWidth = 6;
            this.BookingNumber.Name = "BookingNumber";
            this.BookingNumber.ReadOnly = true;
            // 
            // CusName
            // 
            this.CusName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.CusName.DefaultCellStyle = dataGridViewCellStyle37;
            this.CusName.HeaderText = "Customer Name";
            this.CusName.MinimumWidth = 6;
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.DataPropertyName = "CheckIn";
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Checkin.DefaultCellStyle = dataGridViewCellStyle38;
            this.Checkin.HeaderText = "Check in";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.DataPropertyName = "CheckOut";
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Checkout.DefaultCellStyle = dataGridViewCellStyle39;
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.MinimumWidth = 6;
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // BookingDate
            // 
            this.BookingDate.DataPropertyName = "BookingDate";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.BookingDate.DefaultCellStyle = dataGridViewCellStyle40;
            this.BookingDate.HeaderText = "Booking Date";
            this.BookingDate.MinimumWidth = 6;
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.ReadOnly = true;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.DataPropertyName = "PaymentStatus";
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.PaymentStatus.DefaultCellStyle = dataGridViewCellStyle41;
            this.PaymentStatus.HeaderText = "Payment Status";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            // 
            // Bookingstatus
            // 
            this.Bookingstatus.DataPropertyName = "BookingStatus";
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Bookingstatus.DefaultCellStyle = dataGridViewCellStyle42;
            this.Bookingstatus.HeaderText = "Booking Status";
            this.Bookingstatus.MinimumWidth = 6;
            this.Bookingstatus.Name = "Bookingstatus";
            this.Bookingstatus.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.combx_Bookingstatus);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.combx_paymentstatus);
            this.panel1.Location = new System.Drawing.Point(55, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1651, 230);
            this.panel1.TabIndex = 5;
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
            this.Search.Location = new System.Drawing.Point(1387, 356);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(69, 25);
            this.Search.TabIndex = 16;
            this.Search.Text = "Search:";
            // 
            // txb_customer_name
            // 
            this.txb_customer_name.BorderColor = System.Drawing.Color.Black;
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
            this.txb_customer_name.Location = new System.Drawing.Point(1477, 343);
            this.txb_customer_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_customer_name.Name = "txb_customer_name";
            this.txb_customer_name.PasswordChar = '\0';
            this.txb_customer_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txb_customer_name.PlaceholderText = "Customer Name";
            this.txb_customer_name.SelectedText = "";
            this.txb_customer_name.Size = new System.Drawing.Size(229, 48);
            this.txb_customer_name.TabIndex = 17;
            this.txb_customer_name.TextChanged += new System.EventHandler(this.txb_customer_name_TextChanged);
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
            this.Btn_addRoom.Location = new System.Drawing.Point(1608, 13);
            this.Btn_addRoom.Name = "Btn_addRoom";
            this.Btn_addRoom.Size = new System.Drawing.Size(109, 45);
            this.Btn_addRoom.TabIndex = 18;
            this.Btn_addRoom.Text = "      Add  ";
            this.Btn_addRoom.Click += new System.EventHandler(this.Btn_addRoom_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(50, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(141, 20);
            this.label28.TabIndex = 20;
            this.label28.Text = "Payment Status:";
            // 
            // combx_paymentstatus
            // 
            this.combx_paymentstatus.BackColor = System.Drawing.Color.Transparent;
            this.combx_paymentstatus.BorderColor = System.Drawing.Color.Black;
            this.combx_paymentstatus.BorderRadius = 5;
            this.combx_paymentstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_paymentstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_paymentstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_paymentstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_paymentstatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.combx_paymentstatus.ForeColor = System.Drawing.Color.Black;
            this.combx_paymentstatus.ItemHeight = 30;
            this.combx_paymentstatus.Items.AddRange(new object[] {
            "pending",
            "Success",
            "Failed",
            "Partialy paid"});
            this.combx_paymentstatus.Location = new System.Drawing.Point(214, 68);
            this.combx_paymentstatus.Name = "combx_paymentstatus";
            this.combx_paymentstatus.Size = new System.Drawing.Size(306, 36);
            this.combx_paymentstatus.TabIndex = 19;
            this.combx_paymentstatus.SelectedIndexChanged += new System.EventHandler(this.combx_paymentstatus_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.label27.Location = new System.Drawing.Point(599, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(138, 20);
            this.label27.TabIndex = 22;
            this.label27.Text = "Booking Status:";
            // 
            // combx_Bookingstatus
            // 
            this.combx_Bookingstatus.BackColor = System.Drawing.Color.Transparent;
            this.combx_Bookingstatus.BorderColor = System.Drawing.Color.Black;
            this.combx_Bookingstatus.BorderRadius = 5;
            this.combx_Bookingstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_Bookingstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_Bookingstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_Bookingstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_Bookingstatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.combx_Bookingstatus.ForeColor = System.Drawing.Color.Black;
            this.combx_Bookingstatus.ItemHeight = 30;
            this.combx_Bookingstatus.Items.AddRange(new object[] {
            "pending",
            "Success",
            "Canceled"});
            this.combx_Bookingstatus.Location = new System.Drawing.Point(756, 65);
            this.combx_Bookingstatus.Name = "combx_Bookingstatus";
            this.combx_Bookingstatus.Size = new System.Drawing.Size(306, 36);
            this.combx_Bookingstatus.TabIndex = 21;
            this.combx_Bookingstatus.SelectedIndexChanged += new System.EventHandler(this.combx_Bookingstatus_SelectedIndexChanged);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(212, 15);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(48, 23);
            this.lb_date.TabIndex = 24;
            this.lb_date.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Room Management";
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
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private System.Windows.Forms.Label label28;
        private Guna.UI2.WinForms.Guna2ComboBox combx_paymentstatus;
        private System.Windows.Forms.Label label27;
        private Guna.UI2.WinForms.Guna2ComboBox combx_Bookingstatus;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label2;
    }
}