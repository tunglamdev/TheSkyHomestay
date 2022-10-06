using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Services;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Image;
using TheSkyHomestay.DTO.Room;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _imageService;
        private readonly IRoomService _roomService;
        public ImagesController(IImageService imageService, IRoomService roomService)
        {
            _imageService = imageService;
            _roomService = roomService;
        }

        [HttpGet("ByRoomId/{RoomId}")]
        public async Task<IActionResult> GetByRoomId([FromRoute] int RoomId)
        {
            var checkRoomExist = await _roomService.GetByIdAsync(RoomId);
            if (checkRoomExist.StatusCode == 200)
            {
                var result = await _imageService.GetByRoomIdAsync(RoomId);
                if (result.StatusCode == 200)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result.Message);
            }
            return NotFound(checkRoomExist.Message);
        }

        [HttpGet("{ImageId}")]
        public async Task<IActionResult> GetById([FromRoute] int ImageId)
        {
            var result = await _imageService.GetByIdAsync(ImageId);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost()]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CreateImageDTO request)
        {
            var checkRoomExist = await _roomService.GetByIdAsync(request.RoomId);
            if (checkRoomExist.StatusCode == 200)
            {
                var result = await _imageService.CreateAsync(request);
                if (result.StatusCode == 400)
                {
                    return BadRequest(result.Message);
                }
                return Ok(result.Message);
            }
            return NotFound(checkRoomExist.Message);
        }

        [HttpDelete("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete([FromRoute] int Id)
        {
            var result = await _imageService.DeleteAsync(Id);
            if (result.StatusCode == 404)
            {
                return NotFound(result.Message);
            }
            return Ok(result.Message);
        }
    }
}
