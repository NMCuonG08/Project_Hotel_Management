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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_complete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_hide = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.eye_p = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txb_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.uc_FG = new Hotel_Management.uc_FGpass();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel2.Location = new System.Drawing.Point(66, 281);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(154, 23);
            this.linkLabel2.TabIndex = 76;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Register an account";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(326, 281);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 23);
            this.linkLabel1.TabIndex = 75;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // btn_complete
            // 
            this.btn_complete.BorderRadius = 30;
            this.btn_complete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_complete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_complete.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_complete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_complete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_complete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_complete.FocusedColor = System.Drawing.Color.White;
            this.btn_complete.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_complete.ForeColor = System.Drawing.Color.Black;
            this.btn_complete.Location = new System.Drawing.Point(158, 382);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(263, 70);
            this.btn_complete.TabIndex = 72;
            this.btn_complete.Text = "Sign in";
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txb_password);
            this.guna2Panel1.Controls.Add(this.txb_email);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btn_hide);
            this.guna2Panel1.Controls.Add(this.eye_p);
            this.guna2Panel1.Controls.Add(this.guna2GradientTileButton2);
            this.guna2Panel1.Controls.Add(this.guna2GradientTileButton1);
            this.guna2Panel1.Controls.Add(this.btn_complete);
            this.guna2Panel1.Controls.Add(this.linkLabel1);
            this.guna2Panel1.Controls.Add(this.linkLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(345, 79);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(590, 629);
            this.guna2Panel1.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 45);
            this.label1.TabIndex = 100;
            this.label1.Text = "Sign in";
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.btn_hide.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_hide.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_hide.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hide.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_hide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_hide.FillColor = System.Drawing.Color.Transparent;
            this.btn_hide.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_hide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Image = global::Hotel_Management.Properties.Resources.hide;
            this.btn_hide.Location = new System.Drawing.Point(462, 237);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(36, 25);
            this.btn_hide.TabIndex = 99;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // eye_p
            // 
            this.eye_p.BackColor = System.Drawing.Color.Transparent;
            this.eye_p.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.eye_p.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eye_p.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eye_p.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eye_p.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eye_p.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eye_p.FillColor = System.Drawing.Color.Gainsboro;
            this.eye_p.FillColor2 = System.Drawing.Color.Gainsboro;
            this.eye_p.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.eye_p.ForeColor = System.Drawing.Color.White;
            this.eye_p.Image = global::Hotel_Management.Properties.Resources.view1;
            this.eye_p.Location = new System.Drawing.Point(462, 237);
            this.eye_p.Name = "eye_p";
            this.eye_p.Size = new System.Drawing.Size(36, 25);
            this.eye_p.TabIndex = 98;
            this.eye_p.Click += new System.EventHandler(this.eye_p_Click);
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.guna2GradientTileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.Image = global::Hotel_Management.Properties.Resources._lock;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(17, 221);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(47, 41);
            this.guna2GradientTileButton2.TabIndex = 97;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.BackgroundImage = global::Hotel_Management.Properties.Resources.user__1_3;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.Image = global::Hotel_Management.Properties.Resources.user__1_4;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(17, 156);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(47, 46);
            this.guna2GradientTileButton1.TabIndex = 96;
            // 
            // txb_email
            // 
            this.txb_email.BorderColor = System.Drawing.Color.DimGray;
            this.txb_email.BorderRadius = 10;
            this.txb_email.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txb_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_email.DefaultText = "";
            this.txb_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.ForeColor = System.Drawing.Color.Black;
            this.txb_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_email.Location = new System.Drawing.Point(70, 156);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_email.Name = "txb_email";
            this.txb_email.PasswordChar = '\0';
            this.txb_email.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txb_email.PlaceholderText = "Enter email";
            this.txb_email.SelectedText = "";
            this.txb_email.Size = new System.Drawing.Size(393, 46);
            this.txb_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_email.TabIndex = 101;
            // 
            // txb_password
            // 
            this.txb_password.BorderColor = System.Drawing.Color.DimGray;
            this.txb_password.BorderRadius = 10;
            this.txb_password.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_password.DefaultText = "";
            this.txb_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.ForeColor = System.Drawing.Color.Black;
            this.txb_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_password.Location = new System.Drawing.Point(70, 210);
            this.txb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '●';
            this.txb_password.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txb_password.PlaceholderText = "Password";
            this.txb_password.SelectedText = "";
            this.txb_password.Size = new System.Drawing.Size(393, 52);
            this.txb_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txb_password.TabIndex = 102;
            this.txb_password.UseSystemPasswordChar = true;
            // 
            // uc_FG
            // 
            this.uc_FG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uc_FG.Location = new System.Drawing.Point(1031, 79);
            this.uc_FG.Name = "uc_FG";
            this.uc_FG.Size = new System.Drawing.Size(654, 629);
            this.uc_FG.TabIndex = 80;
            this.uc_FG.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 30);
            this.label2.TabIndex = 103;
            this.label2.Text = "to your account";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management.Properties.Resources.hotel_1749602_1280;
            this.ClientSize = new System.Drawing.Size(1775, 1008);
            this.Controls.Add(this.uc_FG);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_complete;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private Guna.UI2.WinForms.Guna2GradientTileButton eye_p;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_hide;
        private System.Windows.Forms.Label label1;
        private uc_FGpass uc_FG;
        private Guna.UI2.WinForms.Guna2TextBox txb_email;
        private Guna.UI2.WinForms.Guna2TextBox txb_password;
        private System.Windows.Forms.Label label2;
    }
}