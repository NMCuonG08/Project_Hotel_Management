﻿using System;
using System.Collections;
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
    public partial class Fcheckout : Form
    {
        private int HotelID;
        BookingDAO bookingDAO = new BookingDAO();
        public Fcheckout(int hotelID)
        {
            InitializeComponent();
            this.HotelID = hotelID;
            Getdata();
        }
        public void Getdata()
        {
                gv_book.DataSource = bookingDAO.GetCheckOutInformation(this.HotelID);
                gv_book.Columns["UserID"].Visible = false;
                gv_book.Columns["HotelID"].Visible = false;
                gv_book.Columns["RoomID"].Visible = false;
                gv_book.Columns["PaymentStatus"].Visible = false;
                gv_book.Columns["BookingStatus"].Visible = false;
                gv_book.Columns["Price"].Visible = false;
                gv_book.Columns["BookingDate"].Visible = false;
                gv_book.Columns["isCheckOut"].Visible = false;
        }
        private void gv_book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_book.CurrentCell.OwningColumn.Name == "btn_checkout")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    int bookingId = Convert.ToInt32(selectedRow.Cells["BookingNumber"].Value);
                    int roomId = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                    int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                    Room room = Instance.GetRoomByID(roomId);
                    Account user = Instance.GetUserByID(userId);
                    FBookingInformation booking = new FBookingInformation(room, user, HotelID, bookingId);
                    booking.btn_checkout.Visible = true;
                    (this.MdiParent as Admin)?.ShowForm(booking);
                }
            }
            if (gv_book.CurrentCell.OwningColumn.Name == "btn_extend")
            {
                if (e.RowIndex >= 0)
                {
                    DataGridView dgv = sender as DataGridView;
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    int bookingId = Convert.ToInt32(selectedRow.Cells["BookingNumber"].Value);
                    int roomId = Convert.ToInt32(selectedRow.Cells["RoomID"].Value);
                    int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                    Room room = Instance.GetRoomByID(roomId);
                    Account user = Instance.GetUserByID(userId);
                    FExtendBooking booking = new FExtendBooking(room, user, HotelID, bookingId);

                    (this.MdiParent as Admin)?.ShowForm(booking);
                }
            }
        }

        private void txb_customer_name_TextChanged(object sender, EventArgs e)
        {
                    gv_book.DataSource = bookingDAO.Seacrch(HotelID, txb_customer_name);
                    gv_book.Columns["UserID"].Visible = false;
                    gv_book.Columns["HotelID"].Visible = false;
                    gv_book.Columns["RoomID"].Visible = false;         
        }
    }
}
