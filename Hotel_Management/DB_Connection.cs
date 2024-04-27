using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
namespace Hotel_Management
{
    internal class DB_Connection
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;";

        SqlConnection conn = new
           SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");


        SqlConnection link = null;
        public SqlCommand comm = null;
        SqlDataAdapter data = null;
        string connectString;

        public DB_Connection()
        {
            connectString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;";
            link = new SqlConnection(connectString);
            comm = link.CreateCommand();
        }

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


       
        public void MyExecuteNonQuery(string command)
        {
            try
            {
                link.Close();
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                link.Close();
            }
        }
        public void MyExecuteNonQuery(string command, SqlParameter[] parameters)
        {
            try
            {
                link.Close();
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                if (parameters != null)
                {
                    comm.Parameters.AddRange(parameters);
                }

                comm.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                link.Close();
            }
        }

        public SqlDataReader ExecuteQueryDataReader(string sqlString, SqlParameter[] parameters)
        {
            SqlDataReader reader = null;
            try
            {
                link.Close();
                link.Open();
                SqlCommand command = link.CreateCommand();
                command.CommandText = sqlString;
                
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return reader;
        }
        public object MyExecuteScalar(string command,  SqlParameter[] parameters)
        {
            try
            {
                link.Close();
                link.Open();
                comm = link.CreateCommand();
                comm.CommandText = command;
                comm.CommandType = CommandType.Text;
                if (parameters != null)
                {
                    comm.Parameters.AddRange(parameters);
                }
                object result = comm.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                link.Close();
            }
        }

        public DataTable ExecuteQueryDataTable(string sqlString)
        {
            link.Close();
            link.Open();
            comm = link.CreateCommand();
            comm.CommandText = sqlString;
            data = new SqlDataAdapter(comm);
            DataTable dataSet = new DataTable();
            data.Fill(dataSet);
            link.Close();
            return dataSet;
        }
    }
}
