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
    public partial class FUserInformation : Form
    {
        int UserID;
        BookingDAO bookingDAO = new BookingDAO();
        public FUserInformation(int userID)
        {
            InitializeComponent();
            UserID = userID;
            SetData();
            SetData2();
        }

        private void SetData()
        {  
                    gvBooking.DataSource = bookingDAO.LoadBookingByUserID(UserID);
                    gvBooking.Columns["UserID"].Visible = false;
                    gvBooking.Columns["HotelID"].Visible = false;
                    gvBooking.Columns["RoomID"].Visible = false;
                    gvBooking.Columns["CustomerName"].Visible = false;
                    gvBooking.Columns["ID"].Visible = false;
                    gvBooking.Columns["BookingStatus"].Visible = false;
        }

        private void FUserInformation_Load(object sender, EventArgs e)
        {
            panel_info.Visible = true;
            panel_changepassword.Visible = false;
            panel_Transaction_history.Visible = false;
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            panel_info.Visible = true;
            panel_changepassword.Visible = false;
            panel_Transaction_history.Visible = false;
            btn_changepassword.BackColor = Color.White;
            btn_changepassword.ForeColor = Color.Black;
            btn_account.BackColor = Color.FromArgb(0, 192, 192);
            btn_account.ForeColor = Color.White;
            btn_mybooking.BackColor = Color.White;
            btn_mybooking.ForeColor = Color.Black;
        }

        private void btn_mybooking_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_changepassword.Visible = false;
            panel_Transaction_history.Visible = true;
            btn_changepassword.BackColor = Color.White;
            btn_changepassword.ForeColor = Color.Black;
            btn_account.BackColor = Color.White;
            btn_account.ForeColor = Color.Black;
            btn_mybooking.BackColor = Color.FromArgb(0, 192, 192);
            btn_mybooking.ForeColor = Color.White;
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_changepassword.Visible = true;
            panel_Transaction_history.Visible = false;
            btn_changepassword.BackColor = Color.FromArgb(0, 192, 192);
            btn_changepassword.ForeColor = Color.White;
            btn_account.BackColor = Color.White;
            btn_account.ForeColor = Color.Black;
            btn_mybooking.BackColor = Color.White;
            btn_mybooking.ForeColor = Color.Black;
        }

        private void gvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvBooking.CurrentCell.OwningColumn.Name == "btn_cancel")
            {
                if (e.RowIndex >= 0)
                {
                    DialogResult resuilt = message.Show("Bạn có muốn hủy đặt phòng không", "Xác nhận hủy đặt phòng");
                    if (resuilt == DialogResult.Yes)
                    {
                        DataGridView dgv = sender as DataGridView;
                        DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                        int bookingId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                         bookingDAO.CancelBooking(bookingId);
                        thongbao.Show($"Hủy thành công!", "Thông báo");
                        SetData();
                    }
                    else
                    {

                    }
                }
            }
            else if (gvBooking.CurrentCell.OwningColumn.Name == "btn_rate")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    int roomID = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                    int hotelID = Convert.ToInt32(selectedRow.Cells["HotelID"].Value);
                    int price = Convert.ToInt32(selectedRow.Cells["Price"].Value);
                    FEvaluate fEvaluate = new FEvaluate(hotelID, roomID, UserID, price);
                    fEvaluate.ShowDialog();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvBooking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=RoomManagement;Integrated Security=True;Encrypt=False;");
        void SetData2()
        {
            Account user = Instance.user;
            txb_phonenumber.Text = user.Phonenumber;
            txb_useremail.Text = user.Useremail;
            lb_email.Text = user.Useremail;
            txb_idcardnumber.Text = user.Idcardnumber;
            txb_national.Text = user.National;
            txb_address.Text = user.Address;
            txb_gender.Text = user.Gender;
            txb_nameuser.Text = Instance.Getname(user.Id);
            lb_fullname.Text = Instance.Getname(user.Id);
        }
        void ReverseSetData()
        {
            Account user = Instance.user;
            user.Phonenumber = txb_phonenumber.Text;
            user.Useremail = txb_useremail.Text;
            user.Idcardnumber = txb_idcardnumber.Text;
            user.National = txb_national.Text;
            user.Address = txb_address.Text;
            user.Gender = txb_gender.Text;
        }


        private void btn_cancel_info_Click(object sender, EventArgs e)
        {
            SetData2();
        }

        private void btn_save_info_Click(object sender, EventArgs e)
        {
            conn.Open();
            Account user = Instance.user;
            ReverseSetData();
            string query = String.Format("UPDATE UserRegister SET Phonenumber = '{0}', " +
                "[Useremail] = '{1}', " +
                "[Idcardnumber] = '{2}', " +
                "[National] = '{3}', " +
                "[Address] = '{4}', " +
                "[Genders] = '{5}' WHERE ID = {6}", user.Phonenumber, user.Useremail, user.Idcardnumber,
                user.National, user.Address, user.Gender, user.Id);
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            query = String.Format("IF NOT EXISTS (SELECT * FROM UserFullName WHERE UID = {0} )" +
                "BEGIN " +
                "   INSERT INTO UserFullName(Name, UID) Values ('{1}',{0})" +
                "END " +
                "ELSE " +
                "BEGIN" +
                "   UPDATE UserFullName SET Name = '{1}' WHERE UID = {0} " +
                "END", Instance.user.Id, txb_nameuser.Text);
            sqlCommand = new SqlCommand(query, conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
            thongbao.Show("Thay đổi thông tin thành công", "Thông báo");
            
        }

        private void btn_savepassword_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (Instance.user.Password == txb_oldpass.Text.ToString())
            {
                if (txb_newpass.Text == txb_conf.Text)
                {
                    string query = String.Format("UPDATE UserRegister SET Password = '{0}' WHERE ID = {1}", txb_newpass.Text, Instance.user.Id);
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    
                    thongbao.Show("Bạn thay đổi mật khẩu thành công!", "Thông báo");
                }
            }
            else
            {
                thongbao.Show("Thông tin bạn nhập sai!", "Thông báo");
            }
            conn.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Instance.Isloggedout = true;
            this.Close();
        }

        private void FilterBookingData(string filterExpression)
        {
            try
            {
               using (SqlConnection connection = DB_Connection.GetSqlConnection())
                {
                    connection.Open();
                    string query = "Select * from Booking where UserID = @id And BookingStatus = @condition";
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@id", UserID);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@condition", filterExpression);
                    dataAdapter.Fill(data);
                    gvBooking.DataSource = data;
                    gvBooking.Columns["UserID"].Visible = false;
                    gvBooking.Columns["HotelID"].Visible = false;
                    gvBooking.Columns["RoomID"].Visible = false;
                    gvBooking.Columns["CustomerName"].Visible = false;
                    gvBooking.Columns["ID"].Visible = false;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                message.Show(ex.Message);
            }
        }

        private void btn_pending_Click(object sender, EventArgs e)
        {
            FilterBookingData("pending");
        }

        private void btn_success_Click(object sender, EventArgs e)
        {
            FilterBookingData("Success");
        }

        private void btn_cancel_status_Click(object sender, EventArgs e)
        {
            FilterBookingData("Canceled");
        }

    }
}
