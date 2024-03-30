using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Hotel_Management
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;";

        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");


        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        public static Account admin;
        public static Admin fad;
        static Admin tmp;
        public static void Openadmin()
        {
            tmp = fad;
            fad = new Admin(admin);
            tmp.Close();
            fad.ShowDialog();
        }

        public DataTable LoadForm(string query)
        {
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                string sqlStrr = $"SELECT * FROM {query}";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStrr, conn);
                adapter.Fill(data);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }


    }
}
