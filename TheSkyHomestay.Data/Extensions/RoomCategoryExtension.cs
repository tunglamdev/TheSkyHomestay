using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class RoomCategoryExtension
    {
        public static void FillDataRoomCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomCategory>().HasData(
                new RoomCategory() { 
                    Id = 1, 
                    Name = "Phòng 1 giường", 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new RoomCategory() { 
                    Id = 2, 
                    Name = "Phòng 2 giường", 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                }
            );
        }
    }
}