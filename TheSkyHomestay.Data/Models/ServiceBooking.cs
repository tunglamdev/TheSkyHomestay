using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class ServiceBooking
    {
        public int BillId { get; set; }
        public int ServiceId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        public DateTime BookingTime { get; set; }
        public DateTime CancelingTime { get; set; }
        public bool IsCanceled { get; set; }
        public virtual Service Service { get; set; }
        public virtual Bill Bill { get; set; }
    }
}