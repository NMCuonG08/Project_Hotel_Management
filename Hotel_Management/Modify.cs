using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hotel_Management
{
     class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlcommand;// dung de truy van cac cau lenh
        SqlDataReader reader;
        public List<Taikhoan> Taikhoans(string query) // check tai khoan email
        {
            List<Taikhoan> taikhoans = new List<Taikhoan>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    taikhoans.Add(new Taikhoan(reader.GetString(0), reader.GetString(1)));
                }
                connection.Close();
            }
            return taikhoans;
        }
        public void command(string query) // dung de dang ki tai khoan
        {
            using (SqlConnection connection=Connection.GetSqlConnection())
            {
                connection.Open();
                sqlcommand = new SqlCommand(query, connection);
                sqlcommand.ExecuteReader(); // thuc thi truy van
                connection.Close();
            }
        }
    }
    
}
