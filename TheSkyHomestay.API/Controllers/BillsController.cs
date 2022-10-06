using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Services;
using TheSkyHomestay.DTO.Bill;
using TheSkyHomestay.DTO.Bookings;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly IBillService _billService;
        public BillsController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpGet("GetById/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var result = await _billService.GetByIdAsync(Id);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
