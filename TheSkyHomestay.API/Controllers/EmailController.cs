using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.Email;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("Send")]
        public IActionResult SendEmail([FromBody] SendEmailDTO request)
        {
            _emailService.SendEmail(request);
            return Ok();
        }

        [HttpPost("SendFromGuest")]
        public IActionResult SendEmailFromGuest([FromBody] SendEmailDTO request)
        {
            _emailService.SendEmailFromGuest(request);
            return Ok();
        }
    }
}