using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TheSkyHomestay.Application.IServices;
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
});

builder.Services.AddIdentity<User, UserRole>()
                .AddEntityFrameworkStores<TheSkyHomestayDbContext>()
                .AddDefaultTokenProviders();

builder.Services.AddIdentityCore<User>(opt =>
{
    opt.User.AllowedUserNameCharacters = "";
});

//Declare DI
builder.Services.AddTransient<IRoomCategoryService, RoomCategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TheSkyHomestay.API v1"));
}
app.UseCors("CORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
