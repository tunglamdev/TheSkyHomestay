using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Application.Identity
{
    public class CurrentUser : ICurrentUser
    {
        public string UserName { get => _httpContextAccessor.HttpContext.User.FindFirstValue("UserName"); }
        public string UserId { get => _httpContextAccessor.HttpContext.User.FindFirstValue("Id"); }
        public string Email { get => _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Email); }
        public string Name { get => _httpContextAccessor.HttpContext.User.FindFirstValue("Name"); }
        public string CINo { get => _httpContextAccessor.HttpContext.User.FindFirstValue("CINo"); }
        public string PhoneNumber { get => _httpContextAccessor.HttpContext.User.FindFirstValue("PhoneNumber"); }
        public ClaimsPrincipal User { get => _httpContextAccessor.HttpContext.User; }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool IsAdmin()
        {
            return UserName.Equals("skyadmin");
        }
    }
}