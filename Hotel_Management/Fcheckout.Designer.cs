namespace Hotel_Management
{
    partial class Fcheckout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv_booked = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckout = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_extendbooking = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_booked)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_booked
            // 
            this.gv_booked.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_booked.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_booked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_booked.ColumnHeadersHeight = 30;
            this.gv_booked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_booked.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.CustomerName,
            this.CustomerPhone,
            this.RoomNo,
            this.RoomType,
            this.Checkin,
            this.Checkout,
            this.btnCheckout,
            this.btn_extendbooking});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_booked.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_booked.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_booked.Location = new System.Drawing.Point(3, 182);
            this.gv_booked.Name = "gv_booked";
            this.gv_booked.ReadOnly = true;
            this.gv_booked.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_booked.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_booked.RowHeadersVisible = false;
            this.gv_booked.RowHeadersWidth = 51;
            this.gv_booked.RowTemplate.Height = 30;
            this.gv_booked.Size = new System.Drawing.Size(1666, 323);
            this.gv_booked.TabIndex = 0;
            this.gv_booked.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_booked.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_booked.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gv_booked.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_booked.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_booked.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_booked.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_booked.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.gv_booked.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_booked.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_booked.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_booked.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_booked.ThemeStyle.HeaderStyle.Height = 30;
            this.gv_booked.ThemeStyle.ReadOnly = true;
            this.gv_booked.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_booked.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_booked.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_booked.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gv_booked.ThemeStyle.RowsStyle.Height = 30;
            this.gv_booked.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_booked.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_booked.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_booked_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 30.17087F;
            this.id.HeaderText = "#";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.FillWeight = 113.7694F;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.HeaderText = "Phone Number";
            this.CustomerPhone.MinimumWidth = 6;
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.FillWeight = 113.7694F;
            this.RoomNo.HeaderText = "Room No";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.FillWeight = 113.7694F;
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.FillWeight = 113.7694F;
            this.Checkin.HeaderText = "Check in";
            this.Checkin.MinimumWidth = 6;
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.FillWeight = 113.7694F;
            this.Checkout.HeaderText = "Check out";
            this.Checkout.MinimumWidth = 6;
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // btnCheckout
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCheckout.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnCheckout.FillWeight = 96.2567F;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.HeaderText = "Check out";
            this.btnCheckout.MinimumWidth = 6;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.ReadOnly = true;
            // 
            // btn_extendbooking
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Aqua;
            this.btn_extendbooking.DefaultCellStyle = dataGridViewCellStyle4;
            this.btn_extendbooking.FillWeight = 90.95629F;
            this.btn_extendbooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_extendbooking.HeaderText = "Extend Booking";
            this.btn_extendbooking.MinimumWidth = 6;
            this.btn_extendbooking.Name = "btn_extendbooking";
            this.btn_extendbooking.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Booked Rooms";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txb_search);
            this.guna2Panel1.Controls.Add(this.gv_booked);
            this.guna2Panel1.Location = new System.Drawing.Point(38, 168);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1690, 523);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1299, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search:";
            // 
            // txb_search
            // 
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.DefaultText = "";
            this.txb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Location = new System.Drawing.Point(1440, 112);
            this.txb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_search.Name = "txb_search";
            this.txb_search.PasswordChar = '\0';
            this.txb_search.PlaceholderText = "";
            this.txb_search.SelectedText = "";
            this.txb_search.Size = new System.Drawing.Size(229, 48);
            this.txb_search.TabIndex = 1;
            // 
            // Fcheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1740, 816);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "Fcheckout";
            this.Text = "Fcheckout";
            ((System.ComponentModel.ISupportInitialize)(this.gv_booked)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView gv_booked;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txb_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewButtonColumn btnCheckout;
        private System.Windows.Forms.DataGridViewButtonColumn btn_extendbooking;
    }
}