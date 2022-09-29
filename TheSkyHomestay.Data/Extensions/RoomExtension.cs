using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class RoomExtension
    {
        public static void FillDataRoom(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasData(
                new Room() { 
                    Id = 1, 
                    Name = "Hollywood", 
                    Price = 500000, 
                    CategoryId = 1, 
                    Stars = 5, 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new Room() { 
                    Id = 2, 
                    Name = "Tokyo", 
                    Price = 500000, 
                    CategoryId = 1, 
                    Stars = 5, 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new Room() { 
                    Id = 3, 
                    Name = "Berlin", 
                    Price = 500000, 
                    CategoryId = 1, 
                    Stars = 4.5, 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new Room() { 
                    Id = 4, 
                    Name = "Paris", 
                    Price = 800000, 
                    CategoryId = 2, 
                    Stars = 5, 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new Room() { 
                    Id = 5, 
                    Name = "California", 
                    Price = 800000, 
                    CategoryId = 2, 
                    Stars = 5, 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                }
            );
        }
    }
}
