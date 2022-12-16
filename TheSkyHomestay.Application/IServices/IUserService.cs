using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Tourist;

namespace TheSkyHomestay.Application.IServices
{
    public interface IUserService
    {
        Task<ApiResult<List<TouristDTO>>> GetAllMemberAsync();
        Task<ApiResult<List<TouristDTO>>> GetAllGuestAsync();
        Task<ApiResult<Guid>> RegisterAnonymousAsync(RegisterAnonymousDTO request);
        Task<IdentityResult> RegisterAsync(RegisterDTO request);
        Task<ApiResult<string>> LoginAsync(LoginDTO request);
        Task<bool> IsUserNameExistsAsync(string userName);
    }
}
