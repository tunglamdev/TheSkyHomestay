using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class RoomCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        public virtual List<Room> Rooms { get; set; }
    }
}