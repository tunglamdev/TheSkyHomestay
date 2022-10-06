using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Bookings
{
    public class BookingDTO
    {
        public Guid TouristId { get; set; }
        public List<CreateRoomBookingDTO> Rooms { get; set; }
        public List<CreateServiceBookingDTO> Services { get; set; }
    }
}
