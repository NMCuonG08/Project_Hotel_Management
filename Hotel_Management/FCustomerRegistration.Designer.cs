namespace Hotel_Management
{
    partial class FCustomerRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_complete = new Guna.UI2.WinForms.Guna2Button();
            this.txb_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_roomNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_bed = new Guna.UI2.WinForms.Guna2TextBox();
            this.datepkCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.datepk_db = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_nationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_roomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.txb_gender);
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Controls.Add(this.btn_complete);
            this.panel1.Controls.Add(this.txb_price);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txb_roomNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txb_bed);
            this.panel1.Controls.Add(this.datepkCheckin);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txb_address);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txb_id);
            this.panel1.Controls.Add(this.datepk_db);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txb_nationality);
            this.panel1.Controls.Add(this.txb_phone);
            this.panel1.Controls.Add(this.txb_roomType);
            this.panel1.Controls.Add(this.txb_name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1639, 863);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txb_gender
            // 
            this.txb_gender.BackColor = System.Drawing.Color.Transparent;
            this.txb_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_gender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txb_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txb_gender.ItemHeight = 30;
            this.txb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txb_gender.Location = new System.Drawing.Point(30, 357);
            this.txb_gender.Name = "txb_gender";
            this.txb_gender.Size = new System.Drawing.Size(359, 36);
            this.txb_gender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_gender.TabIndex = 63;
            this.txb_gender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_gender_KeyDown);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(843, 66);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(865, 531);
            this.guna2DataGridView1.TabIndex = 62;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_complete
            // 
            this.btn_complete.BorderRadius = 26;
            this.btn_complete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_complete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_complete.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_complete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_complete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_complete.FillColor = System.Drawing.Color.White;
            this.btn_complete.FocusedColor = System.Drawing.Color.White;
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complete.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.Location = new System.Drawing.Point(361, 659);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(180, 55);
            this.btn_complete.TabIndex = 61;
            this.btn_complete.Text = "Allote Room";
            this.btn_complete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_complete_KeyDown);
            // 
            // txb_price
            // 
            this.txb_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_price.DefaultText = "";
            this.txb_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_price.Location = new System.Drawing.Point(455, 560);
            this.txb_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_price.Name = "txb_price";
            this.txb_price.PasswordChar = '\0';
            this.txb_price.PlaceholderText = "";
            this.txb_price.SelectedText = "";
            this.txb_price.Size = new System.Drawing.Size(359, 36);
            this.txb_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_price.TabIndex = 60;
            this.txb_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_price_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(451, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "Price";
            // 
            // txb_roomNo
            // 
            this.txb_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.txb_roomNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_roomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_roomNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txb_roomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txb_roomNo.ItemHeight = 30;
            this.txb_roomNo.Items.AddRange(new object[] {
            "01A",
            "02A",
            "03A",
            "04A",
            "05A",
            "06A"});
            this.txb_roomNo.Location = new System.Drawing.Point(455, 459);
            this.txb_roomNo.Name = "txb_roomNo";
            this.txb_roomNo.Size = new System.Drawing.Size(359, 36);
            this.txb_roomNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_roomNo.TabIndex = 58;
            this.txb_roomNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_roomNo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(451, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 57;
            this.label11.Text = "Room No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(451, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "Room Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Bed";
            // 
            // txb_bed
            // 
            this.txb_bed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_bed.DefaultText = "";
            this.txb_bed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_bed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_bed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_bed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_bed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_bed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_bed.Location = new System.Drawing.Point(455, 262);
            this.txb_bed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_bed.Name = "txb_bed";
            this.txb_bed.PasswordChar = '\0';
            this.txb_bed.PlaceholderText = "";
            this.txb_bed.SelectedText = "";
            this.txb_bed.Size = new System.Drawing.Size(359, 36);
            this.txb_bed.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_bed.TabIndex = 54;
            this.txb_bed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_bed_KeyDown);
            // 
            // datepkCheckin
            // 
            this.datepkCheckin.Checked = true;
            this.datepkCheckin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepkCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepkCheckin.Location = new System.Drawing.Point(455, 147);
            this.datepkCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepkCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepkCheckin.Name = "datepkCheckin";
            this.datepkCheckin.Size = new System.Drawing.Size(359, 42);
            this.datepkCheckin.TabIndex = 53;
            this.datepkCheckin.Value = new System.DateTime(2024, 2, 5, 14, 4, 9, 15);
            this.datepkCheckin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datepkCheckin_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Check in";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Address";
            // 
            // txb_address
            // 
            this.txb_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_address.DefaultText = "";
            this.txb_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_address.Location = new System.Drawing.Point(455, 65);
            this.txb_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_address.Name = "txb_address";
            this.txb_address.PasswordChar = '\0';
            this.txb_address.PlaceholderText = "Complete Adress";
            this.txb_address.SelectedText = "";
            this.txb_address.Size = new System.Drawing.Size(359, 36);
            this.txb_address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_address.TabIndex = 50;
            this.txb_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_address_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 49;
            this.label6.Text = "ID Proof";
            // 
            // txb_id
            // 
            this.txb_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_id.DefaultText = "";
            this.txb_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_id.Location = new System.Drawing.Point(28, 561);
            this.txb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_id.Name = "txb_id";
            this.txb_id.PasswordChar = '\0';
            this.txb_id.PlaceholderText = "Enter ID";
            this.txb_id.SelectedText = "";
            this.txb_id.Size = new System.Drawing.Size(359, 36);
            this.txb_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_id.TabIndex = 48;
            this.txb_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_id_KeyDown);
            // 
            // datepk_db
            // 
            this.datepk_db.Checked = true;
            this.datepk_db.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepk_db.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepk_db.Location = new System.Drawing.Point(28, 460);
            this.datepk_db.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepk_db.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepk_db.Name = "datepk_db";
            this.datepk_db.Size = new System.Drawing.Size(359, 36);
            this.datepk_db.TabIndex = 47;
            this.datepk_db.Value = new System.DateTime(2024, 2, 5, 14, 4, 9, 15);
            this.datepk_db.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datepk_db_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Day Of Birth";
            // 
            // txb_nationality
            // 
            this.txb_nationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_nationality.DefaultText = "";
            this.txb_nationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_nationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_nationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_nationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_nationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_nationality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_nationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_nationality.Location = new System.Drawing.Point(28, 263);
            this.txb_nationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_nationality.Name = "txb_nationality";
            this.txb_nationality.PasswordChar = '\0';
            this.txb_nationality.PlaceholderText = "Nationality";
            this.txb_nationality.SelectedText = "";
            this.txb_nationality.Size = new System.Drawing.Size(359, 36);
            this.txb_nationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_nationality.TabIndex = 45;
            this.txb_nationality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_nationality_KeyDown);
            // 
            // txb_phone
            // 
            this.txb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_phone.DefaultText = "";
            this.txb_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_phone.Location = new System.Drawing.Point(28, 154);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.PasswordChar = '\0';
            this.txb_phone.PlaceholderText = "Enter Contact No";
            this.txb_phone.SelectedText = "";
            this.txb_phone.Size = new System.Drawing.Size(359, 36);
            this.txb_phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_phone.TabIndex = 44;
            this.txb_phone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_phone_KeyDown);
            // 
            // txb_roomType
            // 
            this.txb_roomType.BackColor = System.Drawing.Color.Transparent;
            this.txb_roomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txb_roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txb_roomType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txb_roomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txb_roomType.ItemHeight = 30;
            this.txb_roomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.txb_roomType.Location = new System.Drawing.Point(455, 357);
            this.txb_roomType.Name = "txb_roomType";
            this.txb_roomType.Size = new System.Drawing.Size(359, 36);
            this.txb_roomType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_roomType.TabIndex = 43;
            this.txb_roomType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_roomType_KeyDown);
            // 
            // txb_name
            // 
            this.txb_name.BorderRadius = 10;
            this.txb_name.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_name.DefaultText = "";
            this.txb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Location = new System.Drawing.Point(28, 66);
            this.txb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.PlaceholderText = "Enter Full Name";
            this.txb_name.SelectedText = "";
            this.txb_name.Size = new System.Drawing.Size(359, 36);
            this.txb_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_name.TabIndex = 41;
            this.txb_name.Enter += new System.EventHandler(this.txb_name_Enter);
            this.txb_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_name_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nationality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mobile No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // FCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 863);
            this.Controls.Add(this.panel1);
            this.Name = "FCustomerRegistration";
            this.Text = "FCustomerRegistration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_complete;
        private Guna.UI2.WinForms.Guna2TextBox txb_price;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox txb_roomNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txb_bed;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepkCheckin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txb_address;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txb_id;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepk_db;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txb_nationality;
        private Guna.UI2.WinForms.Guna2TextBox txb_phone;
        private Guna.UI2.WinForms.Guna2ComboBox txb_roomType;
        private Guna.UI2.WinForms.Guna2TextBox txb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txb_gender;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}