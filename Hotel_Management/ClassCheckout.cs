using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    internal class ClassCheckout
    {
        public static string Constring = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=True";
        public static SqlConnection conn = new SqlConnection(Constring);
        public static int SQL(string qury, Hashtable ht)
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qury, conn);
                cmd.CommandType = CommandType.Text;
                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);

                }
                if (conn.State == ConnectionState.Closed) { conn.Open(); };
                res = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open) { conn.Close(); };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
            return res;
        }
        // for loading data from database
        public static void Dataload(string qury, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qury, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colnam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colnam1].DataPropertyName = dt.Columns[i].ToString();
                }
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }
    }
   
}
