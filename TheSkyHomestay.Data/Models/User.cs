using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.Models
{
    public class User : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CINo { get; set; }
        public string Avatar { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public bool IsBlocked { get; set; }
    }
}