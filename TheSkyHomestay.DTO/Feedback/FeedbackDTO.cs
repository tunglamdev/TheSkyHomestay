using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Feedback
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
        public string TouristName { get; set; }
        public string Avatar { get; set; }
        public int Vote { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
