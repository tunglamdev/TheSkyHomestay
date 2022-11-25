using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using TheSkyHomestay.DTO.Tourist;
using Refit;
using TheSkyHomestay.CustomerSite.Models;
using TheSkyHomestay.Integration.Interfaces;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace TheSkyHomestay.CustomerSite.Controllers
{
    public class AccountController : Controller
    {
        private IUserAPI _userApi;
        private IConfiguration _configuration;
        public AccountController(IConfiguration configuration)
        {
            _userApi = RestService.For<IUserAPI>("https://localhost:7241");
            _configuration = configuration;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            string token = _userApi.Login(request).GetAwaiter().GetResult();
            if(string.IsNullOrEmpty(token))
            {
                TempData["Message"] = "Tài khoản email hoặc mật khẩu không chính xác!";
                return View();
            }

            ClaimsPrincipal userPrincipal = ValidateToken(token);
            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
            };
            HttpContext.Session.SetString("Token", token);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, authProperties);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDTO request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var result = _userApi.Register(request).GetAwaiter().GetResult();
            if (!result.Succeeded)
            {
                TempData["Message"] = "Mật khẩu chưa trùng khớp!";
                return View();
            }

            return RedirectToAction("Login", "Account");
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;
            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];
            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
