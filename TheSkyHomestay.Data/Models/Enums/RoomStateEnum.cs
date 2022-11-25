using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models.Enums
{
    public enum RoomStateEnum : int
    {
        [Description("This room is booked")]
        Booked = 1,
        [Description("This room is available")]
        Available = 2,
    }
}
