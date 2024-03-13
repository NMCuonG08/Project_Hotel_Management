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
            this.SuspendLayout();
            // 
            // txb_invoce_number
            // 
            this.txb_invoce_number.BorderRadius = 10;
            this.txb_invoce_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_invoce_number.DefaultText = "";
            this.txb_invoce_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_invoce_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_invoce_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_invoce_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_invoce_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_invoce_number.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_invoce_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_invoce_number.Location = new System.Drawing.Point(218, 93);
            this.txb_invoce_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_invoce_number.Name = "txb_invoce_number";
            this.txb_invoce_number.PasswordChar = '\0';
            this.txb_invoce_number.PlaceholderText = "";
            this.txb_invoce_number.SelectedText = "";
            this.txb_invoce_number.Size = new System.Drawing.Size(420, 48);
            this.txb_invoce_number.TabIndex = 0;
            // 
            // combx_pymethod
            // 
            this.combx_pymethod.BackColor = System.Drawing.Color.Transparent;
            this.combx_pymethod.BorderRadius = 10;
            this.combx_pymethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combx_pymethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combx_pymethod.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_pymethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combx_pymethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combx_pymethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combx_pymethod.ItemHeight = 30;
            this.combx_pymethod.Items.AddRange(new object[] {
            "Paypal",
            "Visa",
            "Cash"});
            this.combx_pymethod.Location = new System.Drawing.Point(218, 206);
            this.combx_pymethod.Name = "combx_pymethod";
            this.combx_pymethod.Size = new System.Drawing.Size(420, 36);
            this.combx_pymethod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invoice Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Added Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            // 
            // txb_add_date
            // 
            this.txb_add_date.BorderRadius = 10;
            this.txb_add_date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_add_date.DefaultText = "";
            this.txb_add_date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_add_date.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_add_date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_add_date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_add_date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_add_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_add_date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_add_date.Location = new System.Drawing.Point(218, 149);
            this.txb_add_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_add_date.Name = "txb_add_date";
            this.txb_add_date.PasswordChar = '\0';
            this.txb_add_date.PlaceholderText = "";
            this.txb_add_date.SelectedText = "";
            this.txb_add_date.Size = new System.Drawing.Size(420, 50);
            this.txb_add_date.TabIndex = 6;
            // 
            // txb_amount
            // 
            this.txb_amount.BorderRadius = 10;
            this.txb_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_amount.DefaultText = "";
            this.txb_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_amount.Location = new System.Drawing.Point(218, 263);
            this.txb_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_amount.Name = "txb_amount";
            this.txb_amount.PasswordChar = '\0';
            this.txb_amount.PlaceholderText = "";
            this.txb_amount.SelectedText = "";
            this.txb_amount.Size = new System.Drawing.Size(420, 48);
            this.txb_amount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payment";
            // 
            // btn_save
            // 
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(218, 373);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 45);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            // 
            // FAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 509);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_amount);
            this.Controls.Add(this.txb_add_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combx_pymethod);
            this.Controls.Add(this.txb_invoce_number);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAddPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}