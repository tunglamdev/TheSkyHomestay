using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.DTO.Bookings
{
    public class AnonymousBookingDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CINo { get; set; }
        public int RoomId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public decimal Price { get; set; }
        public int NumberOfAdult { get; set; }
        public int NumberOfChild { get; set; }
        public List<int> Services { get; set; }
        public List<int> AmountService { get; set; }
    }
}
