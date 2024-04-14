using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FFeedBack : Form
    {
        int HotelID;
        public FFeedBack(int hotelID)
        {
            InitializeComponent();
            HotelID = hotelID;
            SetData();
            CreateItem();
        }

        private void SetData()
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();

                    string query = "Select * from Evaluate where HotelID = @hotelID";
                    DataTable data = new DataTable();
                    SqlDataAdapter sqlData  = new SqlDataAdapter(query, connection);
                    sqlData.SelectCommand.Parameters.AddWithValue("@hotelID", HotelID);
                    sqlData.Fill(data);
                    gv_feedback.DataSource = data;

                    string query2 = "Select AVG(Rate) from Evaluate where HotelID = @hotelID";
                    SqlCommand sqlCommand = new SqlCommand(query2, connection);
                    sqlCommand.Parameters.Add("@hotelID", HotelID);
                    object result = sqlCommand.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        btn_point.Text = result.ToString();
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateItem()
        {
            int count = gv_feedback.Rows.Count;
            if (count > 0)
            {
                UCFeedback[] ls = new UCFeedback[count];
                for (int i = 0; i < count - 1; i++)
                {
                    ls[i] = new UCFeedback();
                    object rate = gv_feedback.Rows[i].Cells[1].Value;
                    double ratee;
                    if (rate != null && Double.TryParse(rate.ToString(), out ratee))
                    {
                        ls[i].Rate = ratee;
                    }

                    object comment = gv_feedback.Rows[i].Cells[2].Value;
                    if (comment != null)
                    {
                        ls[i].Comment = comment.ToString();
                    }

                    DateTime date;
                    object dt = gv_feedback.Rows[i].Cells[5].Value;
                    if (dt != null && DateTime.TryParse(dt.ToString(), out date))
                    {
                        ls[i].Date = date;
                    }
                    object user = gv_feedback.Rows[i].Cells[4].Value;
                    int userID;
                    if (user != null && int.TryParse(user.ToString(), out userID))
                    {
                        
                        Account UserG = Instance.GetUserByID(userID);
                        ls[i].Email = UserG.Useremail;
                    }

                    flow.Controls.Add(ls[i]);

                }

            }
        }


    }
}
