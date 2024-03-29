﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int AdultCapacity { get; set; }
        public int ChildCapacity { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public virtual RoomCategory Category { get; set; }
        public virtual List<RoomImage> Images { get; set; }
    }
}