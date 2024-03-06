namespace Hotel_Management
{
    partial class FLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ckb_remember = new System.Windows.Forms.CheckBox();
            this.btn_complete = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 611);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_complete);
            this.panel3.Controls.Add(this.guna2TextBox1);
            this.panel3.Controls.Add(this.txb_name);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ckb_remember);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(46, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 557);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::Hotel_Management.Properties.Resources._103178_lock_security_password_secure_unlock_icon1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(66, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(49, 38);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Hotel_Management.Properties.Resources._8665305_envelope_email_icon1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(66, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 38);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(181, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login  user";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(117, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(117, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Address";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Hotel_Management.Properties.Resources.Working_remotely_amico;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(653, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 551);
            this.panel2.TabIndex = 13;
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
            this.txb_name.Location = new System.Drawing.Point(121, 220);
            this.txb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_name.Name = "txb_name";
            this.txb_name.PasswordChar = '\0';
            this.txb_name.PlaceholderText = "Enter password";
            this.txb_name.SelectedText = "";
            this.txb_name.Size = new System.Drawing.Size(368, 36);
            this.txb_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_name.TabIndex = 42;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(121, 149);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Enter email";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(368, 36);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 43;
            // 
            // ckb_remember
            // 
            this.ckb_remember.AutoSize = true;
            this.ckb_remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ckb_remember.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ckb_remember.Location = new System.Drawing.Point(121, 277);
            this.ckb_remember.Name = "ckb_remember";
            this.ckb_remember.Size = new System.Drawing.Size(119, 20);
            this.ckb_remember.TabIndex = 8;
            this.ckb_remember.Text = "Remember me";
            this.ckb_remember.UseVisualStyleBackColor = true;
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
            this.btn_complete.FillColor = System.Drawing.Color.PowderBlue;
            this.btn_complete.FocusedColor = System.Drawing.Color.White;
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_complete.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.Location = new System.Drawing.Point(121, 329);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(368, 45);
            this.btn_complete.TabIndex = 62;
            this.btn_complete.Text = "Login";
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1266, 610);
            this.Controls.Add(this.panel1);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox txb_name;
        private Guna.UI2.WinForms.Guna2Button btn_complete;
        private System.Windows.Forms.CheckBox ckb_remember;
    }
}