using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.Service;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService _serviceService;
        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var result = await _serviceService.GetAllAsync();
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var result = await _serviceService.GetByIdAsync(Id);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CreateServiceDTO request)
        {
            var result = await _serviceService.CreateAsync(request);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPut()]
        [AllowAnonymous]
        public async Task<IActionResult> Edit([FromBody] EditServiceDTO request)
        {
            var result = await _serviceService.EditAsync(request);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpDelete("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete([FromRoute] int Id)
        {
            var result = await _serviceService.DeleteAsync(Id);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
