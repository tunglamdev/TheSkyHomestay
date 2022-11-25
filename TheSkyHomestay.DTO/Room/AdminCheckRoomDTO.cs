using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Bookings;

namespace TheSkyHomestay.DTO.Room
{
    public class AdminCheckRoomDTO
    {
        public RoomDTO Room { get; set; }
        public List<BookedTimeDTO> BookedTime { get; set; }
    }
}
