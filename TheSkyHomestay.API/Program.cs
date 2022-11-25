using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using StackExchange.Redis;
using System.Data;
using System.Text;
using System.Text.Json.Serialization;
using TheSkyHomestay.Application.Identity;
using TheSkyHomestay.Application.IServices;
using TheSkyHomestay.Application.Mapping;
using TheSkyHomestay.Application.Services;
using TheSkyHomestay.Data.EF;
using TheSkyHomestay.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

builder.Services.AddDbContext<TheSkyHomestayDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")),
    ServiceLifetime.Transient);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "TheSkyHomestay.Api", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter `Bearer` [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer abcdefghijklmnopqrstuvwxyz\""

    });
    c.AddSecurityRequirement
        (new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    }
                    ,new string[]{}
                }
            }
        );
});

builder.Services.AddIdentityCore<User>(opt =>
{
    opt.User.AllowedUserNameCharacters = "";
});

//Add Asp Net Identity
builder.Services.AddIdentity<User, UserRole>(options =>
{
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 0;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
})
                .AddTokenProvider("The Sky Homestay", typeof(DataProtectorTokenProvider<User>))
                .AddEntityFrameworkStores<TheSkyHomestayDbContext>()
                .AddDefaultTokenProviders();

//Setting password
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 0;
    options.Password.RequiredUniqueChars = 0;
});

//Add HttpContextAccessor
builder.Services.AddHttpContextAccessor();

string issuer = builder.Configuration.GetValue<string>("Tokens:Issuer");
string signingKey = builder.Configuration.GetValue<string>("Tokens:Key");
byte[] signingKeyBytes = Encoding.UTF8.GetBytes(signingKey);

// Adding Authentication
builder.Services.AddAuthentication(options =>
{
    //options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    //options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})

// Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidIssuer = issuer,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});

//Add automapper
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

//Declare DI
builder.Services.AddTransient<IRoomCategoryService, RoomCategoryService>();
builder.Services.AddTransient<IRoomService, RoomService>();
builder.Services.AddTransient<IServiceService, ServiceService>();
builder.Services.AddTransient<IImageService, ImageService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<IBillService, BillService>();
builder.Services.AddTransient<IFeedbackService, FeedbackService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICurrentUser, CurrentUser>();
builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddTransient<UserManager<User>, UserManager<User>>();
builder.Services.AddTransient<RoleManager<UserRole>, RoleManager<UserRole>>();
builder.Services.AddTransient<SignInManager<User>, SignInManager<User>>();

builder.Services.AddMvc()
                .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TheSkyHomestay.API v1"));
}
app.UseCors("CORS");

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
