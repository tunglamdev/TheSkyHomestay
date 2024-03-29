﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.DTO.Tourist;

namespace TheSkyHomestay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController (IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Members")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllMember()
        {
            var result = await _userService.GetAllMemberAsync();
            if(result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpGet("Guests")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllGuest()
        {
            var result = await _userService.GetAllGuestAsync();
            if (result.StatusCode == 400)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Data);
        }

        [HttpPost("AnonymousRegister")]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterAnonymous(RegisterAnonymousDTO request)
        {
            var result = await _userService.RegisterAnonymousAsync(request);
            return Ok(result.Data);
        }

        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            var result = await _userService.RegisterAsync(request);
            return Ok(result.Succeeded);
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            var result = await _userService.LoginAsync(request);
            return Ok(result.Data);
        }
    }
}
