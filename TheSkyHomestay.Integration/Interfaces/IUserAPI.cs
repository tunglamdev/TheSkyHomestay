using Microsoft.AspNetCore.Identity;
using Refit;
using TheSkyHomestay.DTO.Tourist;

namespace TheSkyHomestay.Integration.Interfaces
{
    public interface IUserAPI
    {
        [Post("/api/Users/AnonymousRegister")]
        public Task<Guid> RegisterAnonymous(RegisterAnonymousDTO request);

        [Post("/api/Users/Register")]
        public Task<bool> Register(RegisterDTO request);

        [Post("/api/Users/Login")]
        public Task<string> Login(LoginDTO request);
    }
}
