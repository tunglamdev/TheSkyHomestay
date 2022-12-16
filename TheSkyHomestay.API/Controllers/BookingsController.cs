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
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetBookingDetail/{billId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetBookingDetail([FromRoute] int billId)
        {
            var result = await _bookingService.GetBookingDetailAsync(billId);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("CheckInStatistic")]
        [AllowAnonymous]
        public async Task<IActionResult> CheckInStatistic()
        {
            var result = await _bookingService.CheckInStatistic();
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("RevenueStatistic")]
        [AllowAnonymous]
        public async Task<IActionResult> RevenueStatistic()
        {
            var result = await _bookingService.RevenueStatistic();
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Revenue/GetByDate/{date}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRevenueByDate([FromRoute] DateTime date)
        {
            var result = await _bookingService.GetRevenueByDate(date);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Revenue/GetByMonth/{month}/{year}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRevenueByMonth([FromRoute] int month, [FromRoute] int year)
        {
            var result = await _bookingService.GetRevenueByMonth(month, year);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Revenue/GetByQuarter/{year}/{quarter}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRevenueByQuarter([FromRoute] int year, [FromRoute] int quarter)
        {
            var result = await _bookingService.GetRevenueByQuarter(year, quarter);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Revenue/GetByYear/{year}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetRevenueByYear([FromRoute] int year)
        {
            var result = await _bookingService.GetRevenueByYear(year);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
