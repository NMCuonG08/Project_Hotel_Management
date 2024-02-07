using Guna.UI2.WinForms;
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
    public partial class FAddRoom : Form
    {
        public FAddRoom()
        {
            InitializeComponent();
            txb_roomNum.Focus();
        }

        
        private void txb_roomNum_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            { 
                txb_roomtype.Focus();
                
            }
        }

        private void txb_roomPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add.Focus();
            }
        }
    }
}
