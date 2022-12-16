using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Room;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.CustomerSite.Models
{
    public class RoomsViewModel
    {
        public List<RoomDTO> Rooms;
        public List<ServiceDTO> Services;
        public RoomDTO Room;
        public List<ServiceBookingDTO> ServiceBooking;
        public DateTime CheckInDate;
        public DateTime CheckOutDate;
        public int CategoryId;
        public decimal Total;
        public string TouristName;
        public string Email;
        public string PhoneNumber;
        public string CINo;
        public string ErrorMessage;
        public decimal RoomTotal;
    }
}
