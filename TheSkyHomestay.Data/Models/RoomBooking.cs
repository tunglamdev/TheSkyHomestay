using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class RoomBooking
    {
        public int BillId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Deposit { get; set; }
        public DateTime BookingTime { get; set; }
        public DateTime CancelingTime { get; set; }
        public bool IsCanceled { get; set; }
        public virtual Room Room { get; set; }
        public virtual Bill Bill { get; set; }
    }
}