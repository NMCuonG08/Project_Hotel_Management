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

namespace Hotel_Management
{
    public partial class FAddPayment : Form
    {
        private int BookingID;
        public FAddPayment(int bookingID, FBookingInformation fBooking)
        {
            InitializeComponent();
            this.BookingID = bookingID;
            FBookingInformation = fBooking;
        }

        private int InvoceNumber()
        {
            int number = 0;
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string sql = "Select MAX(ID) from Payment ";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        object result = command.ExecuteScalar();
                        number = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ++number;
        }

        public void SetData()
        {
            txb_invoce_number.Text = InvoceNumber().ToString();
            txb_add_date.Text = DateTime.Now.ToString();
            txb_amount.Text = "0";
            combx_pymethod.SelectedItem = combx_pymethod.Items[2];
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save()
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    string sql = "Insert into Payment values (@AddDate, @PaymentMethod, @Amount, @BookingID)  ";
                    using (SqlCommand command = new SqlCommand (sql, connection))
                    {
                        command.Parameters.Add("@AddDate", SqlDbType.DateTime).Value = txb_add_date.Text;
                        command.Parameters.Add("@PaymentMethod", SqlDbType.NVarChar).Value = combx_pymethod.Text;
                        command.Parameters.Add("@Amount", SqlDbType.Float).Value = txb_amount.Text;
                        command.Parameters.Add("@BookingID", SqlDbType.Int).Value = BookingID;
                        command.ExecuteNonQuery();
                    }
                    connection.Close ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private FBookingInformation FBookingInformation  ;
        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void FAddPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            FBookingInformation.LoadPayment();
        }
    }
}
