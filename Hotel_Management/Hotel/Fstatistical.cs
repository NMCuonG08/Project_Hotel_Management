using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel_Management
{
    public partial class Fstatistical : Form
    {

        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=false";
        private int HotelID;
        BookingDAO bookingDAO = new BookingDAO();

        public Fstatistical(int hotelID)
        {
            this.HotelID = hotelID;
            InitializeComponent();
        }
        private void Getdata()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT* FROM Payment where HotelID = {HotelID}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_turverno.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT* FROM Booking where HotelID = {HotelID}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void printexcel()
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);
            for(int i=1;i<dataGridView1.Columns.Count+1;i++)
            {
                XcelApp.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }
     
        private void Fstatistical_Load(object sender, EventArgs e)
        {
            Getdata();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Truy vấn dữ liệu
                    string query = $@"
                SELECT 
                    YEAR(AddDate) AS [Year], 
                    MONTH(AddDate) AS [Month], 
                    SUM(Amount) AS TotalRevenue
                FROM Payment where HotelID = {HotelID}
                GROUP BY YEAR(AddDate), MONTH(AddDate)
                ORDER BY [Year], [Month]";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Xóa các series hiện có trên biểu đồ
                    chartRevenue.Series.Clear();

                    // Thêm series mới cho biểu đồ cột
                    Series series = chartRevenue.Series.Add("MonthlyRevenue");
                    series.ChartType = SeriesChartType.Column;

                    // Liên kết dữ liệu với biểu đồ
                    chartRevenue.DataSource = dataTable;
                    chartRevenue.Series["MonthlyRevenue"].XValueMember = "Month";
                    chartRevenue.Series["MonthlyRevenue"].YValueMembers = "TotalRevenue";

                    // Đặt nhãn cho trục X (tháng)
                    chartRevenue.ChartAreas[0].AxisX.Title = "Month";

                    // Đặt nhãn cho trục Y (doanh thu)
                    chartRevenue.ChartAreas[0].AxisY.Title = "Total Revenue";

                    // Đặt tên cho các tháng (sử dụng số tháng từ 1 đến 12)
                    chartRevenue.ChartAreas[0].AxisX.Interval = 1;
                    chartRevenue.ChartAreas[0].AxisX.Minimum = 1;
                    chartRevenue.ChartAreas[0].AxisX.Maximum = 12;
                    chartRevenue.ChartAreas[0].AxisX.LabelStyle.Format = "Month {0}";

                    // Cập nhật biểu đồ
                    chartRevenue.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT BookingStatus, COUNT(*) AS BookingCount FROM Booking where HotelID = {HotelID} GROUP BY BookingStatus";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Clear existing series data
                    chart1.Series.Clear();

                    // Add a new series for the chart
                    Series series = chart1.Series.Add("BookingStatus");
                    series.ChartType = SeriesChartType.Pie;

                    // Bind data to the chart
                    chart1.DataSource = dataTable;
                    chart1.Series["BookingStatus"].XValueMember = "BookingStatus";
                    chart1.Series["BookingStatus"].YValueMembers = "BookingCount";

                    /* // Set label format to display percentage
                     chart1.Series["BookingStatus"].Label = "#PERCENT{P0}";*/

                    // Set chart properties
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart1.Legends[0].Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            Getdata();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            printexcel();
        }

        private void btn_drawchart_Click(object sender, EventArgs e)
        {
           
          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btn_turnover_Click(object sender, EventArgs e)
        {

        }
        private void printexcel_turvoner()
        {
            Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
            XcelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dataGridView_turverno.Columns.Count + 1; i++)
            {
                XcelApp.Cells[1, i] = dataGridView_turverno.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView_turverno.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_turverno.Columns.Count; j++)
                {
                    XcelApp.Cells[i + 2, j + 1] = dataGridView_turverno.Rows[i].Cells[j].Value;
                }
            }
            XcelApp.Columns.AutoFit();
            XcelApp.Visible = true;
        }
        private void btn_excelturnover_Click(object sender, EventArgs e)
        {
            printexcel_turvoner();
        }
    }
}

