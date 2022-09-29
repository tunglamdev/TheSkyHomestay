using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public Guid TouristId { get; set; }
        public DateTime CreatedTime { get; set; }
        public virtual User Tourist { get; set; }
    }
}