using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management
{
    public class UserBooking
    {
        public int RoomID { get; set; }
        public int BookingID { get; set; }
        public int Nights { get; set; }
        public int Guests { get; set; }
        public int Price { get; set; }
        public string IsEnded { get; set; }
    }
}
