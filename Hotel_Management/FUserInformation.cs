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
    public partial class FUserInformation : Form
    {
        public FUserInformation()
        {
            InitializeComponent();
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
        }

        private void btn_mybooking_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_changepassword.Visible = false;
            panel_Transaction_history.Visible = true;
        }

        private void btn_changepassword_Click(object sender, EventArgs e)
        {
            panel_info.Visible = false;
            panel_changepassword.Visible = true;
            panel_Transaction_history.Visible = false;
        }
    }
}
