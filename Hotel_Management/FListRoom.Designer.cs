namespace Hotel_Management
{
    partial class FListRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvRoom = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucListRoom1 = new Hotel_Management.UCListRoom();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_btn_clear = new System.Windows.Forms.RadioButton();
            this.radio_btn_checkall = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checklistbox = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_typebed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datetime_to = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_from = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Btn_addRoom = new Guna.UI2.WinForms.Guna2Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Maintenance = new Guna.UI2.WinForms.Guna2Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Checkout = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Booking = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Occupied = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Empty = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvRoom
            // 
            this.gvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRoom.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvRoom.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gvRoom.Location = new System.Drawing.Point(1007, 13);
            this.gvRoom.Name = "gvRoom";
            this.gvRoom.RowHeadersWidth = 51;
            this.gvRoom.RowTemplate.Height = 24;
            this.gvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRoom.Size = new System.Drawing.Size(10, 10);
            this.gvRoom.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.ucListRoom1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 398);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1751, 607);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // ucListRoom1
            // 
            this.ucListRoom1.Checkin = new System.DateTime(((long)(0)));
            this.ucListRoom1.Checkout = new System.DateTime(((long)(0)));
            this.ucListRoom1.Color = System.Drawing.Color.Empty;
            this.ucListRoom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucListRoom1.Image = null;
            this.ucListRoom1.Location = new System.Drawing.Point(3, 3);
            this.ucListRoom1.Name = "ucListRoom1";
            this.ucListRoom1.Price = 0D;
            this.ucListRoom1.RoomID = null;
            this.ucListRoom1.Size = new System.Drawing.Size(879, 179);
            this.ucListRoom1.Status = null;
            this.ucListRoom1.TabIndex = 0;
            this.ucListRoom1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radio_btn_clear);
            this.panel1.Controls.Add(this.gvRoom);
            this.panel1.Controls.Add(this.radio_btn_checkall);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cb_type);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checklistbox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_typebed);
            this.panel1.Controls.Add(this.datetime_to);
            this.panel1.Controls.Add(this.datetime_from);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_status);
            this.panel1.Controls.Add(this.Btn_addRoom);
            this.panel1.Controls.Add(this.lb_date);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1748, 350);
            this.panel1.TabIndex = 6;
            // 
            // radio_btn_clear
            // 
            this.radio_btn_clear.AutoSize = true;
            this.radio_btn_clear.Location = new System.Drawing.Point(1411, 38);
            this.radio_btn_clear.Name = "radio_btn_clear";
            this.radio_btn_clear.Size = new System.Drawing.Size(77, 20);
            this.radio_btn_clear.TabIndex = 40;
            this.radio_btn_clear.TabStop = true;
            this.radio_btn_clear.Text = "Clear all";
            this.radio_btn_clear.UseVisualStyleBackColor = true;
            this.radio_btn_clear.CheckedChanged += new System.EventHandler(this.radio_btn_clear_CheckedChanged);
            // 
            // radio_btn_checkall
            // 
            this.radio_btn_checkall.AutoSize = true;
            this.radio_btn_checkall.Location = new System.Drawing.Point(1297, 37);
            this.radio_btn_checkall.Name = "radio_btn_checkall";
            this.radio_btn_checkall.Size = new System.Drawing.Size(87, 20);
            this.radio_btn_checkall.TabIndex = 39;
            this.radio_btn_checkall.TabStop = true;
            this.radio_btn_checkall.Text = "Choice all";
            this.radio_btn_checkall.UseVisualStyleBackColor = true;
            this.radio_btn_checkall.CheckedChanged += new System.EventHandler(this.radio_btn_checkall_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Type";
            // 
            // cb_type
            // 
            this.cb_type.BackColor = System.Drawing.Color.Transparent;
            this.cb_type.BorderColor = System.Drawing.Color.Black;
            this.cb_type.BorderRadius = 5;
            this.cb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_type.ForeColor = System.Drawing.Color.Black;
            this.cb_type.ItemHeight = 30;
            this.cb_type.Items.AddRange(new object[] {
            "Standard Room",
            "Business Class Room",
            "Family",
            "VIP Room"});
            this.cb_type.Location = new System.Drawing.Point(180, 133);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(306, 36);
            this.cb_type.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1145, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Extensions";
            // 
            // checklistbox
            // 
            this.checklistbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checklistbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checklistbox.FormattingEnabled = true;
            this.checklistbox.Items.AddRange(new object[] {
            "Air_conditioner",
            "TV",
            "Curtains",
            "Desk_workspace",
            "Small_kitchen",
            "Refrigerator",
            "Coffee_maker",
            "Free_bottled_water",
            "Safe_box"});
            this.checklistbox.Location = new System.Drawing.Point(1150, 61);
            this.checklistbox.Name = "checklistbox";
            this.checklistbox.Size = new System.Drawing.Size(402, 220);
            this.checklistbox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(545, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Type bed";
            // 
            // cb_typebed
            // 
            this.cb_typebed.BackColor = System.Drawing.Color.Transparent;
            this.cb_typebed.BorderColor = System.Drawing.Color.Black;
            this.cb_typebed.BorderRadius = 5;
            this.cb_typebed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_typebed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typebed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typebed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_typebed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_typebed.ForeColor = System.Drawing.Color.Black;
            this.cb_typebed.ItemHeight = 30;
            this.cb_typebed.Items.AddRange(new object[] {
            "Single Bed ( 90 - 100 cm)",
            "Double Bed (135 - 150 cm)",
            "Twin bed ( 90 - 100 cm for each)",
            "Queen bed (150 - 160 cm)",
            "King bed (180 - 200 cm)",
            "Sofa bed (sofa instead of bed)"});
            this.cb_typebed.Location = new System.Drawing.Point(662, 133);
            this.cb_typebed.Name = "cb_typebed";
            this.cb_typebed.Size = new System.Drawing.Size(308, 36);
            this.cb_typebed.TabIndex = 13;
            // 
            // datetime_to
            // 
            this.datetime_to.BorderRadius = 5;
            this.datetime_to.Checked = true;
            this.datetime_to.FillColor = System.Drawing.Color.Silver;
            this.datetime_to.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_to.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_to.Location = new System.Drawing.Point(664, 62);
            this.datetime_to.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_to.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_to.Name = "datetime_to";
            this.datetime_to.Size = new System.Drawing.Size(306, 41);
            this.datetime_to.TabIndex = 12;
            this.datetime_to.Value = new System.DateTime(2024, 3, 8, 9, 42, 26, 9);
            // 
            // datetime_from
            // 
            this.datetime_from.Animated = true;
            this.datetime_from.BackColor = System.Drawing.Color.Transparent;
            this.datetime_from.BorderRadius = 5;
            this.datetime_from.Checked = true;
            this.datetime_from.FillColor = System.Drawing.Color.Silver;
            this.datetime_from.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_from.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_from.Location = new System.Drawing.Point(180, 62);
            this.datetime_from.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_from.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_from.Name = "datetime_from";
            this.datetime_from.Size = new System.Drawing.Size(306, 41);
            this.datetime_from.TabIndex = 11;
            this.datetime_from.UseTransparentBackground = true;
            this.datetime_from.Value = new System.DateTime(2024, 3, 8, 9, 42, 26, 9);
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 5;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(180, 193);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(106, 45);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Searching";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "From";
            // 
            // cb_status
            // 
            this.cb_status.BackColor = System.Drawing.Color.Transparent;
            this.cb_status.BorderColor = System.Drawing.Color.Black;
            this.cb_status.BorderRadius = 5;
            this.cb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_status.ForeColor = System.Drawing.Color.Black;
            this.cb_status.ItemHeight = 30;
            this.cb_status.Items.AddRange(new object[] {
            "Empty",
            "Occupied",
            "Booking",
            "Check out",
            "Maintenance"});
            this.cb_status.Location = new System.Drawing.Point(662, 202);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(306, 36);
            this.cb_status.TabIndex = 6;
            // 
            // Btn_addRoom
            // 
            this.Btn_addRoom.BackgroundImage = global::Hotel_Management.Properties.Resources.Add___Copy;
            this.Btn_addRoom.BorderRadius = 10;
            this.Btn_addRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_addRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_addRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_addRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_addRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_addRoom.FillColor = System.Drawing.Color.Teal;
            this.Btn_addRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Btn_addRoom.ForeColor = System.Drawing.Color.White;
            this.Btn_addRoom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_addRoom.Location = new System.Drawing.Point(1561, 13);
            this.Btn_addRoom.Name = "Btn_addRoom";
            this.Btn_addRoom.Size = new System.Drawing.Size(180, 45);
            this.Btn_addRoom.TabIndex = 3;
            this.Btn_addRoom.Text = "Add  new Room";
            this.Btn_addRoom.Click += new System.EventHandler(this.Btn_addRoom_Click);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.Location = new System.Drawing.Point(205, 13);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(48, 23);
            this.lb_date.TabIndex = 2;
            this.lb_date.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Maintenance);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btn_Checkout);
            this.panel2.Controls.Add(this.btn_Booking);
            this.panel2.Controls.Add(this.btn_Occupied);
            this.panel2.Controls.Add(this.btn_Empty);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1738, 55);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_Maintenance
            // 
            this.btn_Maintenance.BorderRadius = 5;
            this.btn_Maintenance.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Maintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Maintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Maintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Maintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Maintenance.FillColor = System.Drawing.Color.Firebrick;
            this.btn_Maintenance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Maintenance.ForeColor = System.Drawing.Color.White;
            this.btn_Maintenance.Location = new System.Drawing.Point(1480, 5);
            this.btn_Maintenance.Name = "btn_Maintenance";
            this.btn_Maintenance.Size = new System.Drawing.Size(56, 49);
            this.btn_Maintenance.TabIndex = 9;
            this.btn_Maintenance.Text = "0";
            this.btn_Maintenance.Click += new System.EventHandler(this.btn_Maintenance_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1542, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = ":Maintenance";
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.BorderRadius = 5;
            this.btn_Checkout.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Checkout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Checkout.Location = new System.Drawing.Point(1129, 5);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(56, 49);
            this.btn_Checkout.TabIndex = 7;
            this.btn_Checkout.Text = "0";
            this.btn_Checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_Booking
            // 
            this.btn_Booking.BorderRadius = 5;
            this.btn_Booking.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Booking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Booking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Booking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Booking.FillColor = System.Drawing.Color.Purple;
            this.btn_Booking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Booking.ForeColor = System.Drawing.Color.White;
            this.btn_Booking.Location = new System.Drawing.Point(760, 5);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Size = new System.Drawing.Size(56, 49);
            this.btn_Booking.TabIndex = 6;
            this.btn_Booking.Text = "0";
            this.btn_Booking.Click += new System.EventHandler(this.btn_booking_Click_1);
            // 
            // btn_Occupied
            // 
            this.btn_Occupied.BorderRadius = 5;
            this.btn_Occupied.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Occupied.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Occupied.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Occupied.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Occupied.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Occupied.FillColor = System.Drawing.Color.LimeGreen;
            this.btn_Occupied.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_Occupied.ForeColor = System.Drawing.Color.White;
            this.btn_Occupied.Location = new System.Drawing.Point(400, 5);
            this.btn_Occupied.Name = "btn_Occupied";
            this.btn_Occupied.Size = new System.Drawing.Size(56, 49);
            this.btn_Occupied.TabIndex = 5;
            this.btn_Occupied.Text = "0";
            this.btn_Occupied.Click += new System.EventHandler(this.btn_occupied_Click);
            // 
            // btn_Empty
            // 
            this.btn_Empty.BorderRadius = 5;
            this.btn_Empty.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.btn_Empty.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Empty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Empty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Empty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Empty.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Empty.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Empty.ForeColor = System.Drawing.Color.White;
            this.btn_Empty.Location = new System.Drawing.Point(40, 5);
            this.btn_Empty.Name = "btn_Empty";
            this.btn_Empty.Size = new System.Drawing.Size(56, 49);
            this.btn_Empty.TabIndex = 4;
            this.btn_Empty.Text = "0";
            this.btn_Empty.Click += new System.EventHandler(this.btn_empty_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1191, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = ":Check out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = ":Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = ":Occupied";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = ":Empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Management";
            // 
            // message
            // 
            this.message.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.message.Caption = null;
            this.message.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.message.Parent = null;
            this.message.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.message.Text = null;
            // 
            // FListRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1775, 1008);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListRoom";
            this.Load += new System.EventHandler(this.ListRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRoom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCListRoom ucListRoom1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_date;
        private Guna.UI2.WinForms.Guna2Button Btn_addRoom;
        private Guna.UI2.WinForms.Guna2Button btn_Checkout;
        private Guna.UI2.WinForms.Guna2Button btn_Booking;
        private Guna.UI2.WinForms.Guna2Button btn_Occupied;
        private Guna.UI2.WinForms.Guna2Button btn_Empty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cb_status;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_to;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_from;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_typebed;
        private System.Windows.Forms.CheckedListBox checklistbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cb_type;
        private System.Windows.Forms.RadioButton radio_btn_clear;
        private System.Windows.Forms.RadioButton radio_btn_checkall;
        private Guna.UI2.WinForms.Guna2Button btn_Maintenance;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2MessageDialog message;
    }
}