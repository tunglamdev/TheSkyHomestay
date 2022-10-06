using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Image
{
    public class CreateImageDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoomId { get; set; }
    }
}
