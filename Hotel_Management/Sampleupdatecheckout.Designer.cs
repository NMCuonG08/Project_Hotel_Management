namespace Hotel_Management
{
    partial class Sampleupdatecheckout
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.datecheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datecheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txb_roomtype = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_roonno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Black;
            this.guna2Separator1.Location = new System.Drawing.Point(24, 72);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(796, 13);
            this.guna2Separator1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.guna2Panel1.Controls.Add(this.btn_close);
            this.guna2Panel1.Controls.Add(this.btn_save);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 391);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(832, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BorderRadius = 10;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Chocolate;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(312, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(180, 45);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BorderRadius = 10;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Chocolate;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(88, 19);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.guna2Panel2.Controls.Add(this.datecheckout);
            this.guna2Panel2.Controls.Add(this.datecheckin);
            this.guna2Panel2.Controls.Add(this.txb_roomtype);
            this.guna2Panel2.Controls.Add(this.txb_roonno);
            this.guna2Panel2.Controls.Add(this.txb_phone);
            this.guna2Panel2.Controls.Add(this.txb_name);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 88);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(832, 302);
            this.guna2Panel2.TabIndex = 2;
            // 
            // datecheckout
            // 
            this.datecheckout.Checked = true;
            this.datecheckout.FillColor = System.Drawing.Color.Silver;
            this.datecheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datecheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datecheckout.Location = new System.Drawing.Point(371, 148);
            this.datecheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datecheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datecheckout.Name = "datecheckout";
            this.datecheckout.Size = new System.Drawing.Size(229, 36);
            this.datecheckout.TabIndex = 5;
            this.datecheckout.Value = new System.DateTime(2024, 4, 3, 0, 22, 27, 276);
            // 
            // datecheckin
            // 
            this.datecheckin.Checked = true;
            this.datecheckin.FillColor = System.Drawing.Color.Silver;
            this.datecheckin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datecheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datecheckin.Location = new System.Drawing.Point(371, 83);
            this.datecheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datecheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datecheckin.Name = "datecheckin";
            this.datecheckin.Size = new System.Drawing.Size(229, 36);
            this.datecheckin.TabIndex = 4;
            this.datecheckin.Value = new System.DateTime(2024, 4, 3, 0, 22, 27, 276);
            // 
            // txb_roomtype
            // 
            this.txb_roomtype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_roomtype.DefaultText = "";
            this.txb_roomtype.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_roomtype.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_roomtype.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_roomtype.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_roomtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomtype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_roomtype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roomtype.Location = new System.Drawing.Point(371, 30);
            this.txb_roomtype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_roomtype.Name = "txb_roomtype";
            this.txb_roomtype.PasswordChar = '\0';
            this.txb_roomtype.PlaceholderText = "Enter Room Type";
            this.txb_roomtype.SelectedText = "";
            this.txb_roomtype.Size = new System.Drawing.Size(229, 33);
            this.txb_roomtype.TabIndex = 3;
            // 
            // txb_roonno
            // 
            this.txb_roonno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_roonno.DefaultText = "";
            this.txb_roonno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_roonno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_roonno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_roonno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_roonno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roonno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_roonno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_roonno.Location = new System.Drawing.Point(45, 148);
            this.txb_roonno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_roonno.Name = "txb_roonno";
            this.txb_roonno.PasswordChar = '\0';
            this.txb_roonno.PlaceholderText = "Enter Room No";
            this.txb_roonno.SelectedText = "";
            this.txb_roonno.Size = new System.Drawing.Size(229, 33);
            this.txb_roonno.TabIndex = 2;
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
            this.txb_phone.Location = new System.Drawing.Point(45, 86);
            this.txb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.PasswordChar = '\0';
            this.txb_phone.PlaceholderText = "Enter Phone";
            this.txb_phone.SelectedText = "";
            this.txb_phone.Size = new System.Drawing.Size(229, 33);
            this.txb_phone.TabIndex = 1;
            // 
            // txb_name
            // 
            this.txb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_name.DefaultText = "";
            this.txb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_name.Location = new System.Drawing.Point(45, 30);
            this.txb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.PlaceholderText = "Enter Name";
            this.txb_name.SelectedText = "";
            this.txb_name.Size = new System.Drawing.Size(229, 33);
            this.txb_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Information";
            // 
            // Sampleupdatecheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sampleupdatecheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fupdate_checkout";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btn_close;
        public Guna.UI2.WinForms.Guna2Button btn_save;
        public Guna.UI2.WinForms.Guna2TextBox txb_name;
        public Guna.UI2.WinForms.Guna2TextBox txb_roomtype;
        public Guna.UI2.WinForms.Guna2TextBox txb_roonno;
        public Guna.UI2.WinForms.Guna2TextBox txb_phone;
        public Guna.UI2.WinForms.Guna2DateTimePicker datecheckout;
        public Guna.UI2.WinForms.Guna2DateTimePicker datecheckin;
    }
}