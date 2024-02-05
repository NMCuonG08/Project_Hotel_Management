namespace Hotel_Management
{
    partial class RoomInformation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvRoom = new System.Windows.Forms.DataGridView();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRoom
            // 
            this.gvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvRoom.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.gvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNumber,
            this.RoomBed,
            this.RoomPrice,
            this.HotelName,
            this.RoomType,
            this.HotelAddress});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvRoom.DefaultCellStyle = dataGridViewCellStyle27;
            this.gvRoom.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gvRoom.Location = new System.Drawing.Point(36, 68);
            this.gvRoom.Name = "gvRoom";
            this.gvRoom.RowHeadersWidth = 51;
            this.gvRoom.RowTemplate.Height = 24;
            this.gvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRoom.Size = new System.Drawing.Size(1125, 668);
            this.gvRoom.TabIndex = 0;
            // 
            // RoomNumber
            // 
            this.RoomNumber.DataPropertyName = "RoomID";
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.RoomNumber.DefaultCellStyle = dataGridViewCellStyle26;
            this.RoomNumber.HeaderText = "Room Number";
            this.RoomNumber.MinimumWidth = 6;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // RoomBed
            // 
            this.RoomBed.DataPropertyName = "RoomBed";
            this.RoomBed.HeaderText = "Room Bed";
            this.RoomBed.MinimumWidth = 6;
            this.RoomBed.Name = "RoomBed";
            this.RoomBed.ReadOnly = true;
            // 
            // RoomPrice
            // 
            this.RoomPrice.DataPropertyName = "RoomPrice";
            this.RoomPrice.HeaderText = "Price per day";
            this.RoomPrice.MinimumWidth = 6;
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.ReadOnly = true;
            // 
            // HotelName
            // 
            this.HotelName.DataPropertyName = "HotelName";
            this.HotelName.HeaderText = "Hotel Name";
            this.HotelName.MinimumWidth = 6;
            this.HotelName.Name = "HotelName";
            this.HotelName.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "RoomType";
            this.RoomType.FillWeight = 150F;
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.MinimumWidth = 6;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // HotelAddress
            // 
            this.HotelAddress.DataPropertyName = "HotelAddress";
            this.HotelAddress.HeaderText = "Hotel Address";
            this.HotelAddress.MinimumWidth = 6;
            this.HotelAddress.Name = "HotelAddress";
            this.HotelAddress.ReadOnly = true;
            // 
            // RoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.gvRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomInformation";
            this.Load += new System.EventHandler(this.RoomInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelAddress;
    }
}