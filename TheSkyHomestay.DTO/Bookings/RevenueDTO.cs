using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Bookings
{
    public class RevenueDTO
    {
        public List<BookingDetailDTO> BookingList { get; set; }
        public int NumberOfChecking { get; set; }
        public decimal Revenue { get; set; }
    }
}
