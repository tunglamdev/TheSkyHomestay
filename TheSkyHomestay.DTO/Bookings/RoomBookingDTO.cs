using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Bookings
{
    public class RoomBookingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfAdult { get; set; }
        public int NumberOfChild { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Deposit { get; set; }
    }
}
