using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FBookingInformation : Form
    {
        Room Room { get; set; }
        Account User { get; set; }
        int HotelID { get; set; }
        int BookingID { get; set; }
        public FBookingInformation()
        {
            InitializeComponent();
            LoadPayment();
        }
        public FBookingInformation(Room room, Account user, int hotelID, int bookingID )    
        {
            this.Room = room;
            this.User = user;
            this.HotelID = hotelID;
            this.BookingID = bookingID;

            InitializeComponent();
            /*panel_details.Visible = true;
            panel_payment.Visible = false;
            panel_room.Visible = false;*/
            ShowDetailsPanel();
            LoadPayment();
            Setlb();
        }

        public void LoadPayment()
        {
            try
            {
                using (SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Payment where BookingID = @BookingID ";
                    DataTable data = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@BookingID", BookingID);
                    dataAdapter.Fill(data);
                    dgv.DataSource = data;
                    dgv.Columns["BookingID"].Visible = false;
                    string sqltotal = " SELECT ISNULL(SUM(Amount), 0) FROM Payment where BookingID = @BookingID";
                    SqlCommand cmd = new SqlCommand(sqltotal, conn);
                    cmd.Parameters.AddWithValue("@BookingID", BookingID);
                    double total = (double)cmd.ExecuteScalar();
                    lbtpaid.Text = total.ToString();

                    string sqlpending = " SELECT ISNULL(Price, 0) FROM Booking where ID = @ID";
                    SqlCommand cmd2 = new SqlCommand(sqlpending, conn);
                    cmd2.Parameters.AddWithValue("@ID", BookingID);
                    double pending = (double)cmd2.ExecuteScalar();
                    double value = pending - total;
                    if ( total == 0)
                    {
                        lb_pendingpay.Text = value.ToString();
                        combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[0];
                    }
                    else if (value > 0)
                    {
                        lb_pendingpay.Text = value.ToString();
                        combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[3];
                    }                  
                    else
                    {
                        lb_pendingpay.Text = "0";
                        Btn_addpayment.Enabled = false;
                        combx_paymentstatus.SelectedItem = combx_paymentstatus.Items[1];
                    }
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FAddPayment fAddPayment = new FAddPayment(BookingID, this);
            fAddPayment.SetData();
            fAddPayment.ShowDialog();
           
        }
        void Setlb()
        {
            Booking booking = Instance.GetBookingByID(BookingID);
            HotelInformation h = Instance.GetHotelInformationByID(HotelID);
          //  MessageBox.Show($"{booking.Username}");
           // MessageBox.Show($"{BookingID}");
            lbName.Text = h.Name.ToString();
            lbCity.Text = h.City.ToString(); 
            lbCountry.Text = h.Country.ToString(); ;
            lbPhone.Text = h.PhoneNumber.ToString();
            lbEmail.Text = h.Email.ToString(); 
            lbgname.Text = booking.Username.ToString(); 
            lbCityy.Text = User.National.ToString();
            lbGCountry.Text = User.National.ToString(); 
            lbGEmail.Text = User.Useremail.ToString(); 
            lbGPhone.Text = User.Phonenumber.ToString();
            //   lbbn.Text = Instance.BID.ToString();
            lb_bookingdate.Text = booking.Bookingdate.ToString();
            lbbn.Text = booking.Id.ToString();
            lbcin.Text = booking.Checkin.ToString();
            lbcout.Text = booking.Checkout.ToString();
            lbps.Text = booking.Paymentstatus.ToString();
            lbbs.Text = booking.Bookingstatus.ToString();
            lbg.Text = "1";
            lbn.Text = "1";
            lbtp.Text = booking.Price.ToString() + " $";
          //  MessageBox.Show($"{ub.RoomID}");
           
            dgv2.Rows[0].Cells[0].Value = Room.Id;
            dgv2.Rows[0].Cells[1].Value = Room.Type.ToString();
            dgv2.Rows[0].Cells[2].Value = Room.Bed;
        }

        private void FBookingInformation_Load(object sender, EventArgs e)
        {
            Setlb();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowDetailsPanel()
        {
            panel_details.Visible = true;
            panel_payment.Visible = false;
            panel_room.Visible = false;

            btn_details.FillColor = Color.White;
            btn_details.ForeColor = Color.Teal;
            btn_payment.FillColor = Color.Teal;
            btn_payment.ForeColor = Color.White;
            btn_room.FillColor = Color.Teal;
            btn_room.ForeColor = Color.White;
        }
        private void btn_details_Click(object sender, EventArgs e)
        {
            ShowDetailsPanel();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            panel_details.Visible = false;
            panel_payment.Visible = true;
            panel_room.Visible = false;
            btn_payment.FillColor = Color.White;
            btn_payment.ForeColor = Color.Teal;
            btn_details.FillColor = Color.Teal;
            btn_details.ForeColor = Color.White;
            btn_room.FillColor = Color.Teal;
            btn_room.ForeColor = Color.White;
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            panel_details.Visible = false;
            panel_payment.Visible = false;
            panel_room.Visible = true;

            btn_room.FillColor = Color.White;
            btn_room.ForeColor = Color.Teal;
            btn_details.FillColor = Color.Teal;
            btn_details.ForeColor = Color.White;
            btn_payment.FillColor = Color.Teal;
            btn_payment.ForeColor = Color.White;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
