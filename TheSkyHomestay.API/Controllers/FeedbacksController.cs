using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Services;
using TheSkyHomestay.DTO.Feedback;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;
        public FeedbacksController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var result = await _feedbackService.GetAllAsync();
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] CreateFeedbackDTO request)
        {
            var result = await _feedbackService.CreateAsync(request);
            if (result.StatusCode == 200)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
