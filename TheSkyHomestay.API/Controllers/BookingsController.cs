using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.Bookings;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("Book")]
        [AllowAnonymous]
        public async Task<IActionResult> Book([FromBody] BookingDTO request)
        {
            var result = await _bookingService.BookAsync(request);
            if (result.StatusCode == 200)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
