using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class UserExtension
    {
        public static void FillDataUser(this ModelBuilder modelBuilder)
        {
            var adminRoleId = new Guid("9E87B492-5343-4272-9A34-FA5DE7CFFB22");
            var userRoleId = new Guid("8F7579EE-4AF9-4B71-9ADA-7F792F76DC31");
            var adminId = new Guid("372EA575-2536-4076-9BAB-3E3138DE495F");
            var userId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4");
            var userId2 = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15");

            //Seed data for UserRole
            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new UserRole
                {
                    Id = userRoleId,
                    Name = "tourist",
                    NormalizedName = "tourist",
                    Description = "Tourist role"
                }
           );

            //Seed data for User
            var hasher = new PasswordHasher<User>();
            var user1 = new User()
            {
                Id = userId,
                Name = "Nguyễn Tùng Lâm",
                Email = "lam@gmail.com",
                PhoneNumber = "0338307449",
                Avatar = "lam.jpg",
                CINo = "333444555",
            };
            var user2 = new User()
            {
                Id = userId2,
                Name = "Nguyễn Văn An",
                Email = "an@gmail.com",
                PhoneNumber = "0338307994",
                Avatar = "an.jpg",
                CINo = "444555666"
            };
            var admin = new User()
            {
                Id = adminId,
                Name = "John",
                Email = "admin@gmail.com",
                PhoneNumber = "0123456789",
                Avatar = "admin.jpg",
                CINo = "777888999"
            };
            user1.Password = hasher.HashPassword(user1, "user123");
            user2.Password = hasher.HashPassword(user2, "user123");
            admin.Password = hasher.HashPassword(admin, "admin123");
            modelBuilder.Entity<User>().HasData(user1, user2, admin);

            //Seed data for IdentityUserRole
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
              new IdentityUserRole<Guid>
              {
                  RoleId = adminRoleId,
                  UserId = adminId,
              },
              new IdentityUserRole<Guid>
              {
                  RoleId = userRoleId,
                  UserId = userId,
              },
              new IdentityUserRole<Guid>
              {
                  RoleId = userRoleId,
                  UserId = userId2,
              });
        }
    }
}
