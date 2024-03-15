namespace Hotel_Management
{
    partial class Book_room
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ucbookroom1 = new Hotel_Management.Ucbookroom();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(489, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK ROOM";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 26;
            this.guna2Panel1.Controls.Add(this.ucbookroom1);
            this.guna2Panel1.Location = new System.Drawing.Point(83, 75);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1213, 500);
            this.guna2Panel1.TabIndex = 1;
            // 
            // ucbookroom1
            // 
            this.ucbookroom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucbookroom1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucbookroom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucbookroom1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucbookroom1.Location = new System.Drawing.Point(3, 3);
            this.ucbookroom1.Name = "ucbookroom1";
            this.ucbookroom1.Size = new System.Drawing.Size(1207, 494);
            this.ucbookroom1.TabIndex = 0;
            // 
            // Book_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 723);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "Book_room";
            this.Text = "Book_room";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Ucbookroom ucbookroom1;
    }
}