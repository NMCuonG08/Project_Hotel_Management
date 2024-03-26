using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hotel_Management
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;";
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

    }
}
