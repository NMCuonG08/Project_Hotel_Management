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
    public class BookingData
    {
        public String Name {  get; set; }
        public String BStat { get; set; }
        public String PStat { get; set; }
        public DateTime CIn { get; set; }
        public DateTime COut { get; set; }
        public DateTime BDate { get; set; }
        public int UserID { get; set; }
        public int HotelID { get; set; }
        public string GCountry { get; set; }
        public string GPhone { get; set; }
        public string GEmail { get; set; }

        public BookingData(string name, DateTime cIn, DateTime cOut, DateTime bDate, string pStat, string bStat, int userID, int hotelID) 
        {
            Name = name;
            BStat = bStat;
            PStat = pStat;
            CIn = cIn;
            COut = cOut;
            BDate = bDate;
            PStat = pStat;
            UserID = userID;
            HotelID = hotelID;
            findUser();
        }
        void findUser() 
        {
            SqlConnection conn= Connection.GetSqlConnection();
            string sql = "SELECT * FROM UserRegister WHERE ID = @ID";
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ID", UserID.ToString());
            dataAdapter.Fill(data);
            DataGridView tmp = new DataGridView();
            tmp.DataSource = data;
            //fix dum nha
            /*GCountry = tmp.Rows[0].Cells[3].Value.ToString();
            GPhone = tmp.Rows[0].Cells[7].Value.ToString();
            GEmail = tmp.Rows[0].Cells[1].Value.ToString();*/
        }
    }
}
