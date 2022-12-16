using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Room
{
    public class CreateRoomDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int AdultCapacity { get; set; }
        public int ChildCapacity { get; set; }
        public int CategoryId { get; set; }
    }
}
