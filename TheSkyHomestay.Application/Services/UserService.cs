using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TheSkyHomestay.Application.Identity;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;
using TheSkyHomestay.DTO.Contants;
using TheSkyHomestay.DTO.Tourist;

namespace TheSkyHomestay.Application.Services
{
    public class UserService : IUserService
    {
        private readonly TheSkyHomestayDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly ICurrentUser _currentUser;
        public UserService(TheSkyHomestayDbContext context, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, ICurrentUser currentUser)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _currentUser = currentUser; 
            _configuration = configuration;
        }

        public async Task<ApiResult<List<TouristDTO>>> GetAllMemberAsync()
        {
            var users = await _context.Users.Where(u => u.IsBlocked == false && u.Password!=null).Select(u => _mapper.Map<TouristDTO>(u)).ToListAsync();
            if(users.Count == 0)
            {
                return new ApiResult<List<TouristDTO>>(null)
                {
                    StatusCode = 400,
                    Message = "Something went wrong!"
                };
            }   
            return new ApiResult<List<TouristDTO>>(users)
            {
                StatusCode = 200,
                Message = "Get users list successfully!"
            };
        }

        public async Task<ApiResult<List<TouristDTO>>> GetAllGuestAsync()
        {
            var users = await _context.Users.Where(u => u.IsBlocked == false && u.Password == null).Select(u => _mapper.Map<TouristDTO>(u)).ToListAsync();
            if (users.Count == 0)
            {
                return new ApiResult<List<TouristDTO>>(null)
                {
                    StatusCode = 400,
                    Message = "Something went wrong!"
                };
            }
            return new ApiResult<List<TouristDTO>>(users)
            {
                StatusCode = 200,
                Message = "Get users list successfully!"
            };
        }

        public async Task<ApiResult<Guid>> RegisterAnonymousAsync(RegisterAnonymousDTO request)
        {
            var check = await _context.Users.Where(u => u.UserName == request.Email).FirstOrDefaultAsync();
            if(check == null)
            {
                var user = new User()
                {
                    Name = request.Name,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    UserName = request.Email,
                    CINo = request.CINo
                };
                var result = await _userManager.CreateAsync(user, "abc123");
                return new ApiResult<Guid>(user.Id)
                {
                    StatusCode = 200,
                    Message = "Create anonynous account successfully!"
                };
            }
            var newUserId = new Guid("00000000-0000-0000-0000-000000000000");
            return new ApiResult<Guid>(newUserId)
            {
                StatusCode = 500,
                Message = "Email is existed!"
            };
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDTO request)
        {

            if (string.Compare(request.Password, request.ConfirmPassword) != 0)
            {
                return IdentityResult.Failed(
                    new IdentityError()
                    {
                        Description = "Password and confirm password must be same.",
                        Code = "400"
                    });
            }

            var user = new User()
            {
                Name = request.Name,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                UserName = request.Email,
                CINo = request.CINo,
                Password = request.Password
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            await _userManager.AddClaimAsync(user, new Claim("id", user.Id.ToString()));
            await _userManager.AddClaimAsync(user, new Claim("userName", user.UserName));
            await _userManager.AddClaimAsync(user, new Claim("name", user.Name));
            await _userManager.AddClaimAsync(user, new Claim("email", user.Email));
            await _userManager.AddClaimAsync(user, new Claim("phoneNumber", user.PhoneNumber));
            await _userManager.AddClaimAsync(user, new Claim("cino", user.CINo));
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.NameIdentifier, user.UserName));
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Name, user.Name));
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Email, user.Email));
            return result;
        }

        public async Task<ApiResult<string>> LoginAsync(LoginDTO request)
        {
            var username = request.UserName;

            // check email is match if user type email
            var emailCheck = await _context.Users.FirstOrDefaultAsync(x => x.Email.ToLower().Equals(request.UserName.ToLower()));
            if (emailCheck != null)
            {
                username = emailCheck.UserName;
            }

            var user = await _userManager.FindByNameAsync(username);

            if (user == null)
            {
                return new ApiResult<string>(null)
                {
                    StatusCode = 404,
                    Message = "Username or password is incorrect!"
                };
            }

            var result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, true, false);

            if (result.IsLockedOut)
            {
                return new ApiResult<string>(null)
                {
                    StatusCode = 400,
                    Message = "Your account has been locked! Please contact administration for more detail."
                };
            }
            if (result.IsNotAllowed || result.RequiresTwoFactor || !result.Succeeded)
            {
                return new ApiResult<string>(null)
                {
                    StatusCode = 400,
                    Message = "Username or password is incorrect!"
                };
            }

            var claims = await _userManager.GetClaimsAsync(user);

            string issuer = _configuration["Tokens:Issuer"];
            string signingKey = _configuration["Tokens:Key"];

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer,
                issuer,
                claims,
                expires: DateTime.Now.AddDays(300),
                signingCredentials: creds);

            return new ApiResult<string>(new JwtSecurityTokenHandler().WriteToken(token))
            {
                StatusCode = 200,
                Message = "Log in successfully!"
            };
        }

        public async Task<bool> IsUserNameExistsAsync(string userName)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                return await _context.Users.AnyAsync(x => x.UserName.Equals(userName));
            }
            return false;
        }
    }
}
