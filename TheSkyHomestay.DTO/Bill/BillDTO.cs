using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Bookings;

namespace TheSkyHomestay.DTO.Bill
{
    public class BillDTO
    {
        public int Id { get; set; }
        public string TouristName{ get; set; }
        public string PhoneNumber{ get; set; }
        public string Email { get; set; }
        public string CiNo { get; set; }
        public decimal Total { get; set; }
        public List<RoomBookingDTO> RoomBookings { get; set; }
        public List<ServiceBookingDTO> ServiceBookings { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
