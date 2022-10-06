using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.RoomCategory;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IRoomCategoryService _roomCategoryService;
        public RoomsController(IRoomService roomService, IRoomCategoryService roomCategoryService)
        {
            _roomService = roomService;
            _roomCategoryService = roomCategoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var result = await _roomService.GetAllAsync();
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
            var result = await _roomService.GetByIdAsync(Id);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Category/{CategoryId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByCategoryId([FromRoute] int CategoryId)
        {
            var checkCategoryId = await _roomCategoryService.GetByIdAsync(CategoryId);
            if(checkCategoryId.StatusCode == 200)
            {
                var result = await _roomService.GetByCategoryIdAsync(CategoryId);
                if (result.StatusCode == 200)
                {
                    return Ok(result.Data);
                }
                return BadRequest(checkCategoryId.Message);
            }
            return NotFound(checkCategoryId.Message);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CreateRoomDTO request)
        {
            var checkRoomCategory = await _roomCategoryService.GetByIdAsync(request.CategoryId);
            if (checkRoomCategory.StatusCode == 200)
            {
                var result = await _roomService.CreateAsync(request);
                if (result.StatusCode == 400)
                {
                    return BadRequest(result.Message);
                }
                return Ok(result.Message);
            }
            return NotFound(checkRoomCategory.Message);
        }

        [HttpPut()]
        [AllowAnonymous]
        public async Task<IActionResult> Edit([FromBody] EditRoomDTO request)
        {
            var checkRoomCategory = await _roomCategoryService.GetByIdAsync(request.CategoryId);
            if(checkRoomCategory.StatusCode == 200)
            {
                var result = await _roomService.EditAsync(request);
                if (result.StatusCode == 400)
                {
                    return BadRequest(result.Message);
                }
                return Ok(result.Message);
            }
            return NotFound(checkRoomCategory.Message);
        }

        [HttpDelete("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete([FromRoute] int Id)
        {
            var result = await _roomService.DeleteAsync(Id);
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
