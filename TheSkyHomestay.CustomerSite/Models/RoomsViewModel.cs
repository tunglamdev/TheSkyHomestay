using TheSkyHomestay.DTO.Room;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.CustomerSite.Models
{
    public class RoomsViewModel
    {
        public List<RoomDTO> Rooms;
        public RoomDTO Room;
        public DateTime CheckInDate;
        public DateTime CheckOutDate;
        public int CategoryId;
        public decimal Total;
        public string TouristName;
        public string Email;
        public string PhoneNumber;
        public string CINo;
        public string ErrorMessage;
    }
}
