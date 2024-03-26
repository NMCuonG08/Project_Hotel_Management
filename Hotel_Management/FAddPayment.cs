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
    public partial class FAddPayment : Form
    {
        public FAddPayment()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Data.invoiceNum = txb_invoce_number.Text.ToString();
            Data.pMethod = combx_pymethod.Text.ToString();
            Data.dt = Convert.ToDateTime(dtp.Text.ToString());
            Data.amount = txb_amount.Text.ToString();
            this.Close();
        }

    }
}
