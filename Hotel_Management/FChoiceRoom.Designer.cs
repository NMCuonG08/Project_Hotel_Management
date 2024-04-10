namespace Hotel_Management
{
    partial class FChoiceRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChoiceRoom));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gvRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetime_checkout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datetime_checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_typebed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_typeroom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel_hide = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.panel_hide.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.gvRoom);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 123);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1859, 935);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gvRoom
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvRoom.ColumnHeadersHeight = 4;
            this.gvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvRoom.Location = new System.Drawing.Point(3, 3);
            this.gvRoom.Name = "gvRoom";
            this.gvRoom.RowHeadersVisible = false;
            this.gvRoom.RowHeadersWidth = 51;
            this.gvRoom.RowTemplate.Height = 24;
            this.gvRoom.Size = new System.Drawing.Size(240, 150);
            this.gvRoom.TabIndex = 3;
            this.gvRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvRoom.ThemeStyle.HeaderStyle.Height = 4;
            this.gvRoom.ThemeStyle.ReadOnly = false;
            this.gvRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvRoom.ThemeStyle.RowsStyle.Height = 24;
            this.gvRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvRoom.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.datetime_checkout);
            this.guna2Panel2.Controls.Add(this.datetime_checkin);
            this.guna2Panel2.Controls.Add(this.btn_close);
            this.guna2Panel2.Controls.Add(this.btn_search);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.cbx_typebed);
            this.guna2Panel2.Controls.Add(this.label11);
            this.guna2Panel2.Controls.Add(this.cbx_typeroom);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1942, 81);
            this.guna2Panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1309, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 126;
            this.label2.Text = "Check out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(937, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 125;
            this.label1.Text = "Check in";
            // 
            // datetime_checkout
            // 
            this.datetime_checkout.BorderColor = System.Drawing.Color.SeaShell;
            this.datetime_checkout.BorderRadius = 10;
            this.datetime_checkout.Checked = true;
            this.datetime_checkout.FillColor = System.Drawing.Color.White;
            this.datetime_checkout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_checkout.Location = new System.Drawing.Point(1435, 13);
            this.datetime_checkout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_checkout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datetime_checkout.Name = "datetime_checkout";
            this.datetime_checkout.Size = new System.Drawing.Size(247, 45);
            this.datetime_checkout.TabIndex = 124;
            this.datetime_checkout.Value = new System.DateTime(2024, 3, 12, 23, 25, 1, 5);
            // 
            // datetime_checkin
            // 
            this.datetime_checkin.BorderColor = System.Drawing.Color.White;
            this.datetime_checkin.BorderRadius = 10;
            this.datetime_checkin.Checked = true;
            this.datetime_checkin.FillColor = System.Drawing.Color.White;
            this.datetime_checkin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datetime_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datetime_checkin.Location = new System.Drawing.Point(1056, 13);
            this.datetime_checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datetime_checkin.MinDate = new System.DateTime(2024, 4, 2, 0, 0, 0, 0);
            this.datetime_checkin.Name = "datetime_checkin";
            this.datetime_checkin.Size = new System.Drawing.Size(247, 45);
            this.datetime_checkin.TabIndex = 123;
            this.datetime_checkin.Value = new System.DateTime(2024, 4, 2, 0, 0, 0, 0);
            this.datetime_checkin.ValueChanged += new System.EventHandler(this.datetime_checkin_ValueChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(1885, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 81);
            this.btn_close.TabIndex = 122;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 10;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Image = global::Hotel_Management.Properties.Resources.loupe;
            this.btn_search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_search.Location = new System.Drawing.Point(1699, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(180, 45);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Type bed";
            // 
            // cbx_typebed
            // 
            this.cbx_typebed.BackColor = System.Drawing.Color.Transparent;
            this.cbx_typebed.BorderColor = System.Drawing.Color.Silver;
            this.cbx_typebed.BorderRadius = 10;
            this.cbx_typebed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_typebed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_typebed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_typebed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_typebed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_typebed.ForeColor = System.Drawing.Color.Black;
            this.cbx_typebed.ItemHeight = 33;
            this.cbx_typebed.Location = new System.Drawing.Point(533, 12);
            this.cbx_typebed.Name = "cbx_typebed";
            this.cbx_typebed.Size = new System.Drawing.Size(398, 39);
            this.cbx_typebed.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Type";
            // 
            // cbx_typeroom
            // 
            this.cbx_typeroom.BackColor = System.Drawing.Color.Transparent;
            this.cbx_typeroom.BorderColor = System.Drawing.Color.Silver;
            this.cbx_typeroom.BorderRadius = 10;
            this.cbx_typeroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_typeroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_typeroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_typeroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_typeroom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_typeroom.ForeColor = System.Drawing.Color.Black;
            this.cbx_typeroom.ItemHeight = 33;
            this.cbx_typeroom.Location = new System.Drawing.Point(84, 12);
            this.cbx_typeroom.Name = "cbx_typeroom";
            this.cbx_typeroom.Size = new System.Drawing.Size(306, 39);
            this.cbx_typeroom.TabIndex = 23;
            // 
            // panel_hide
            // 
            this.panel_hide.BackColor = System.Drawing.Color.White;
            this.panel_hide.Controls.Add(this.label3);
            this.panel_hide.Location = new System.Drawing.Point(83, 186);
            this.panel_hide.Name = "panel_hide";
            this.panel_hide.Size = new System.Drawing.Size(1859, 414);
            this.panel_hide.TabIndex = 3;
            this.panel_hide.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.label3.Location = new System.Drawing.Point(583, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Search Information";
            // 
            // FChoiceRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panel_hide);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChoiceRoom";
            this.Text = "FChoiceRoom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.panel_hide.ResumeLayout(false);
            this.panel_hide.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_typeroom;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_typebed;
        private Guna.UI2.WinForms.Guna2DataGridView gvRoom;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_checkin;
        private Guna.UI2.WinForms.Guna2DateTimePicker datetime_checkout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel panel_hide;
        private System.Windows.Forms.Label label3;
    }
}