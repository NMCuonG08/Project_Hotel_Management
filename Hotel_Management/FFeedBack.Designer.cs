namespace Hotel_Management
{
    partial class FFeedBack
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
            this.btn_point = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flow = new System.Windows.Forms.FlowLayoutPanel();
            this.gv_feedback = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_feedback)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_point
            // 
            this.btn_point.BorderColor = System.Drawing.Color.DimGray;
            this.btn_point.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_point.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_point.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_point.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_point.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_point.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_point.ForeColor = System.Drawing.Color.White;
            this.btn_point.Location = new System.Drawing.Point(121, 145);
            this.btn_point.Name = "btn_point";
            this.btn_point.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btn_point.Size = new System.Drawing.Size(156, 148);
            this.btn_point.TabIndex = 5;
            this.btn_point.Text = "9.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ đánh giá của khách đã ở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F);
            this.label2.Location = new System.Drawing.Point(67, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xếp hạng  & Điểm đánh giá chung";
            // 
            // flow
            // 
            this.flow.Location = new System.Drawing.Point(73, 304);
            this.flow.Name = "flow";
            this.flow.Size = new System.Drawing.Size(1672, 648);
            this.flow.TabIndex = 9;
            // 
            // gv_feedback
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gv_feedback.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_feedback.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_feedback.ColumnHeadersHeight = 4;
            this.gv_feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_feedback.DefaultCellStyle = dataGridViewCellStyle3;
            this.gv_feedback.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_feedback.Location = new System.Drawing.Point(2, 2);
            this.gv_feedback.Name = "gv_feedback";
            this.gv_feedback.RowHeadersVisible = false;
            this.gv_feedback.RowHeadersWidth = 51;
            this.gv_feedback.RowTemplate.Height = 24;
            this.gv_feedback.Size = new System.Drawing.Size(10, 11);
            this.gv_feedback.TabIndex = 10;
            this.gv_feedback.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_feedback.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_feedback.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_feedback.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_feedback.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_feedback.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_feedback.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_feedback.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_feedback.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_feedback.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_feedback.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_feedback.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gv_feedback.ThemeStyle.HeaderStyle.Height = 4;
            this.gv_feedback.ThemeStyle.ReadOnly = false;
            this.gv_feedback.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_feedback.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_feedback.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gv_feedback.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_feedback.ThemeStyle.RowsStyle.Height = 24;
            this.gv_feedback.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_feedback.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 961);
            this.Controls.Add(this.gv_feedback);
            this.Controls.Add(this.flow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFeedBack";
            this.Text = "FFeedBack";
            ((System.ComponentModel.ISupportInitialize)(this.gv_feedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btn_point;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flow;
        private Guna.UI2.WinForms.Guna2DataGridView gv_feedback;
    }
}