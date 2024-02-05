using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management
{
    public partial class RoomInformation : Form
    {
        SqlConnection conn = new
        SqlConnection(Properties.Settings.Default.connStrRoom);
        public RoomInformation()
        {
            InitializeComponent();
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RoomInformation_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM RoomInformation");


                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                gvRoom.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
