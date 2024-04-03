namespace Hotel_Management
{
    partial class FAddPayment
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
            this.txb_invoce_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.combx_pymethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_add_date = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_close = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_invoce_number
            // 
            this.txb_invoce_number.BorderColor = System.Drawing.Color.Black;
            this.txb_invoce_number.BorderRadius = 10;
            this.txb_invoce_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_invoce_number.DefaultText = "";
            this.txb_invoce_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_invoce_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_invoce_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_invoce_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_invoce_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_invoce_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_invoce_number.ForeColor = System.Drawing.Color.Black;
            this.txb_invoce_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_invoce_number.Location = new System.Drawing.Point(235, 190);
            this.txb_invoce_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_invoce_number.Name = "txb_invoce_number";
            this.txb_invoce_number.PasswordChar = '\0';
            this.txb_invoce_number.PlaceholderText = "";
            this.txb_invoce_number.ReadOnly = true;
            this.txb_invoce_number.SelectedText = "";
            this.txb_invoce_number.Size = new System.Drawing.Size(473, 48);
            this.txb_invoce_number.TabIndex = 0;
            // 
            // combx_pymethod
            // 
            this.combx_pymethod.BackColor = System.Drawing.Color.Transparent;
            this.combx_pymethod.BorderColor = System.Drawing.Color.Black;
            this.combx_pymethod.BorderRadius = 10;
            this.combx_pymethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_pymethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_pymethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_pymethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_pymethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.combx_pymethod.ForeColor = System.Drawing.Color.Black;
            this.combx_pymethod.ItemHeight = 30;
            this.combx_pymethod.Items.AddRange(new object[] {
            "Paypal",
            "Visa",
            "Cash"});
            this.combx_pymethod.Location = new System.Drawing.Point(235, 303);
            this.combx_pymethod.Name = "combx_pymethod";
            this.combx_pymethod.Size = new System.Drawing.Size(473, 36);
            this.combx_pymethod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(33, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(75, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Added Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(20, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(113, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            // 
            // txb_add_date
            // 
            this.txb_add_date.BorderColor = System.Drawing.Color.Black;
            this.txb_add_date.BorderRadius = 10;
            this.txb_add_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_add_date.DefaultText = "";
            this.txb_add_date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_add_date.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_add_date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_add_date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_add_date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_add_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_add_date.ForeColor = System.Drawing.Color.Black;
            this.txb_add_date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_add_date.Location = new System.Drawing.Point(235, 246);
            this.txb_add_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_add_date.Name = "txb_add_date";
            this.txb_add_date.PasswordChar = '\0';
            this.txb_add_date.PlaceholderText = "";
            this.txb_add_date.ReadOnly = true;
            this.txb_add_date.SelectedText = "";
            this.txb_add_date.Size = new System.Drawing.Size(473, 50);
            this.txb_add_date.TabIndex = 6;
            // 
            // txb_amount
            // 
            this.txb_amount.BorderColor = System.Drawing.Color.Black;
            this.txb_amount.BorderRadius = 10;
            this.txb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_amount.DefaultText = "";
            this.txb_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_amount.ForeColor = System.Drawing.Color.Black;
            this.txb_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Location = new System.Drawing.Point(235, 360);
            this.txb_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.PasswordChar = '\0';
            this.txb_amount.PlaceholderText = "";
            this.txb_amount.SelectedText = "";
            this.txb_amount.Size = new System.Drawing.Size(473, 48);
            this.txb_amount.TabIndex = 7;
            this.txb_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_amount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(371, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payment";
            // 
            // btn_save
            // 
            this.btn_save.BorderRadius = 10;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(235, 464);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(473, 51);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btn_save);
            this.guna2Panel1.Controls.Add(this.btn_close);
            this.guna2Panel1.Controls.Add(this.txb_invoce_number);
            this.guna2Panel1.Controls.Add(this.combx_pymethod);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txb_amount);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txb_add_date);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Location = new System.Drawing.Point(2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(820, 740);
            this.guna2Panel1.TabIndex = 125;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Hotel_Management.Properties.Resources.bill1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(32, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(190, 110);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 125;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = global::Hotel_Management.Properties.Resources.cross;
            this.btn_close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_close.Location = new System.Drawing.Point(755, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(57, 49);
            this.btn_close.TabIndex = 124;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 740);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddPayment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAddPayment_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txb_invoce_number;
        private Guna.UI2.WinForms.Guna2ComboBox combx_pymethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txb_add_date;
        private Guna.UI2.WinForms.Guna2TextBox txb_amount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        public Guna.UI2.WinForms.Guna2GradientTileButton btn_close;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}