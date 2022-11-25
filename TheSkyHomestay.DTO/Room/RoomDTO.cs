using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models.Enums;
using TheSkyHomestay.DTO.Image;

namespace TheSkyHomestay.DTO.Room
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public List<ImageDTO> Images { get; set; }
        public RoomStateEnum? State { get; set; }
        public int CategoryId { get; set; }
    }
}
