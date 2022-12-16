using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Email;

namespace TheSkyHomestay.Application.IServices
{
    public interface IEmailService
    {
        public void SendEmail(SendEmailDTO request);
        public void SendEmailFromGuest(SendEmailDTO request);
    }
}
