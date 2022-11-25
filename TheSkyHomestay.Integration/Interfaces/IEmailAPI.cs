using Refit;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.Email;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IEmailAPI
    {
        [Post("/api/Email/Send")]
        public Task SendEmail(SendEmailDTO request);
    }
}
