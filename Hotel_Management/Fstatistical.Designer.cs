namespace Hotel_Management
{
    partial class Fstatistical
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_excel = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_excelturnover = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_turverno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_turverno)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excel
            // 
            this.btn_excel.BorderRadius = 10;
            this.btn_excel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_excel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_excel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_excel.FillColor = System.Drawing.Color.Teal;
            this.btn_excel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_excel.ForeColor = System.Drawing.Color.White;
            this.btn_excel.Location = new System.Drawing.Point(78, 666);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(180, 45);
            this.btn_excel.TabIndex = 2;
            this.btn_excel.Text = "Xuất Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1635, 686);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(96, 53);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(142, 172);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "CustormerName";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(704, 466);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(843, 127);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(951, 511);
            this.chartRevenue.TabIndex = 128;
            this.chartRevenue.Text = "chart1";
            // 
            // btn_excelturnover
            // 
            this.btn_excelturnover.BorderRadius = 10;
            this.btn_excelturnover.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_excelturnover.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_excelturnover.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_excelturnover.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_excelturnover.FillColor = System.Drawing.Color.Teal;
            this.btn_excelturnover.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_excelturnover.ForeColor = System.Drawing.Color.White;
            this.btn_excelturnover.Location = new System.Drawing.Point(924, 667);
            this.btn_excelturnover.Name = "btn_excelturnover";
            this.btn_excelturnover.Size = new System.Drawing.Size(180, 44);
            this.btn_excelturnover.TabIndex = 131;
            this.btn_excelturnover.Text = "Xuất Excel";
            this.btn_excelturnover.Click += new System.EventHandler(this.btn_excelturnover_Click);
            // 
            // dataGridView_turverno
            // 
            this.dataGridView_turverno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_turverno.Location = new System.Drawing.Point(1632, 756);
            this.dataGridView_turverno.Name = "dataGridView_turverno";
            this.dataGridView_turverno.RowHeadersWidth = 51;
            this.dataGridView_turverno.RowTemplate.Height = 24;
            this.dataGridView_turverno.Size = new System.Drawing.Size(99, 53);
            this.dataGridView_turverno.TabIndex = 132;
            this.dataGridView_turverno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 37);
            this.label2.TabIndex = 133;
            this.label2.Text = "Thống Kê";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(290, 686);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(297, 25);
            this.Search.TabIndex = 134;
            this.Search.Text = "Bảng thống kê tình trạng đặt phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1173, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 135;
            this.label1.Text = "Bảng thống kê doanh thu";
            // 
            // Fstatistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1840, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_turverno);
            this.Controls.Add(this.btn_excelturnover);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_excel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fstatistical";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fstatistical";
            this.Load += new System.EventHandler(this.Fstatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_turverno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_excel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private Guna.UI2.WinForms.Guna2Button btn_excelturnover;
        private System.Windows.Forms.DataGridView dataGridView_turverno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Label label1;
    }
}