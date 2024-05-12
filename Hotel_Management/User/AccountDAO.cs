using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    internal class AccountDAO
    {
        DB_Connection BDconnection = new DB_Connection();
        public AccountDAO() { }
        public Account GetUserByID(int id)
        {
            Account user = new Account();
            string query = $"Select * from UserRegister where ID = {id}";
            SqlDataReader reader = BDconnection.ExecuteQueryDataReader(query,null);
            if (reader.Read())
            {
                user = new Account
                {
                    Id = id,
                    Useremail = reader["Useremail"].ToString(),
                    Password = reader["Password"].ToString(),
                    National = reader["National"].ToString(),
                    Idcardnumber = reader["Idcardnumber"].ToString(),
                    Gender = reader["Genders"].ToString(),
                    Address = reader["Address"].ToString(),
                    Phonenumber = reader["Phonenumber"].ToString(),
                    // Kiểm tra trước khi chuyển đổi và xử lý giá trị DBNull
                    Birthday = reader["Birthday"] != DBNull.Value ? (DateTime)reader["Birthday"] : DateTime.MinValue,
                    Role = "user"
                };
            }
            return user;
        }

    }
}
