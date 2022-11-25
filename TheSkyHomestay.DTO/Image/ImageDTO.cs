using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Image
{
    public class ImageDTO
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }
        public int RoomId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
