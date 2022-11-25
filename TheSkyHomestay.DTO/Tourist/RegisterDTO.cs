using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.DTO.Tourist
{
    public class RegisterDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CINo { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
