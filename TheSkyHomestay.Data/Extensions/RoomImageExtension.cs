using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class RoomImageExtension
    {
        public static void FillDataRoomImage(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomImage>().HasData(
                new RoomImage()
                {
                    Id = 1,
                    Name = "phong1-1.jpg",
                    Description = "Ảnh phòng 1",
                    RoomId = 1,
                    CreatedTime = DateTime.Now
                },
                new RoomImage()
                {
                    Id = 2,
                    Name = "phong1-2.jpg",
                    Description = "Ảnh phòng 1",
                    RoomId = 1,
                    CreatedTime = DateTime.Now
                },
                new RoomImage()
                {
                    Id = 3,
                    Name = "phong1-3.jpg",
                    Description = "Ảnh phòng 1",
                    RoomId = 1,
                    CreatedTime = DateTime.Now
                },
                new RoomImage()
                {
                    Id = 4,
                    Name = "phong2-1.jpg",
                    Description = "Ảnh phòng 1",
                    RoomId = 2,
                    CreatedTime = DateTime.Now
                },
                new RoomImage()
                {
                    Id = 5,
                    Name = "phong2-1.jpg",
                    Description = "Ảnh phòng 1",
                    RoomId = 2,
                    CreatedTime = DateTime.Now
                }
            );
        }
    }
}
