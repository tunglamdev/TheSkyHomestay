using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Feedback
{
    public class CreateFeedbackDTO
    {
        public Guid TouristId { get; set; }
        public int Vote { get; set; }
        public string Comment { get; set; }
    }
}
