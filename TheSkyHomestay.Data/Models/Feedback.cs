﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public Guid TouristId { get; set; }
        public int Vote { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User Tourist { get; set; }
    }
}