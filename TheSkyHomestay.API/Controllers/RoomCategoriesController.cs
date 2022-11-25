using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Services;
using TheSkyHomestay.DTO.RoomCategory;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomCategoriesController : ControllerBase
    {
        private readonly IRoomCategoryService _roomCategoryService;
        public RoomCategoriesController(IRoomCategoryService roomCategoryService)
        {
            _roomCategoryService = roomCategoryService;
        }

        private string setImageName(string currentName)
        {
            return String.Format("{0}://{1}{2}/images/categories/{3}", Request.Scheme, Request.Host, Request.PathBase, currentName);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var result = await _roomCategoryService.GetAllAsync();
            if (result.StatusCode == 200)
            {
                result.Data.ForEach(r => r.Image = setImageName(r.Image));
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var result = await _roomCategoryService.GetByIdAsync(Id);
            if (result.StatusCode == 404)
            {
                return NotFound(result.Message);
            }
            result.Data.Image = setImageName(result.Data.Image);
            return Ok(result.Data);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CreateRoomCategoryDTO request)
        {
            var result = await _roomCategoryService.CreateAsync(request);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPut()]
        [AllowAnonymous]
        public async Task<IActionResult> Edit([FromBody] EditRoomCategoryDTO request)
        {
            var result = await _roomCategoryService.EditAsync(request);
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
            var result = await _roomCategoryService.DeleteAsync(Id);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
