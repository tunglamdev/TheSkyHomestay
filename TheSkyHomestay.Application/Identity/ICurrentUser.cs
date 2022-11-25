using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Application.Identity
{
    public interface ICurrentUser
    {
        string UserName { get; }
        string UserId { get; }
        string Email { get; }
        string Name { get; }
        string CINo { get; }
        string PhoneNumber { get; }
        ClaimsPrincipal User { get; }
        bool IsAdmin();
    }
}
