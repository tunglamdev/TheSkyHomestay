using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Services;

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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var roomCategories = await _roomCategoryService.GetAllAsync();
            if (roomCategories == null)
            {
                return BadRequest();
            }
            return Ok(roomCategories);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById([FromRoute] int Id)
        {
            var roomCategory = await _roomCategoryService.GetByIdAsync(Id);
            if (roomCategory == null)
            {
                return BadRequest();
            }
            return Ok(roomCategory);
        }
    }
}
