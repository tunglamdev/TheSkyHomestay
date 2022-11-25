using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Bookings
{
    public class BookingDetailDTO
    {
        public string TouristName { get; set; }
        public string Email { get; set; }
        public string CINo { get; set; }
        public string PhoneNumber { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public decimal Total { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
