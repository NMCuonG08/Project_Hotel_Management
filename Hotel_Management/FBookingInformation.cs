using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FBookingInformation : Form
    {
        int idx = 0;
        public FBookingInformation()
        {
            InitializeComponent();
            Data.currentHotelData = Data.ReadData(Data.adminid);
            Setlb();
        }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_addRoom_Click(object sender, EventArgs e)
        {
            FAddPayment fAddPayment = new FAddPayment();
            fAddPayment.ShowDialog();
            dgv1.Rows[idx].Cells[0].Value = Data.dt.ToString("dd/MM/yyyy");
            dgv1.Rows[idx].Cells[1].Value = Data.invoiceNum.ToString();
            dgv1.Rows[idx].Cells[2].Value = Data.pMethod.ToString();
            dgv1.Rows[idx].Cells[3].Value = Data.amount.ToString();
            lbtp.Text = (Convert.ToInt32(lbtp.Text)+Convert.ToInt32(Data.amount)).ToString();
            idx++;
        }

        private void FBookingInformation_Load(object sender, EventArgs e)
        {
            
        }
        void Setlb()
        {
            Data.currentHotelData = Data.ReadData(Data.adminid);
            lbCity.Text = Data.currentHotelData.City.ToString();
            lbCountry.Text = Data.currentHotelData.Country.ToString();
            lbPhone.Text = Data.currentHotelData.PhoneNumber.ToString();
            lbEmail.Text = Data.currentHotelData.Email.ToString();
            lbGName.Text = Data.currentHotelData.Name.ToString();
 /*           lbGCountry.Text = Data.bData.GCountry.ToString();
            lbGEmail.Text = Data.bData.GEmail.ToString();
            lbGPhone.Text = Data.bData .GPhone.ToString();*/
        }
    }
}
