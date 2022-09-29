using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class ServiceExtension
    {
        public static void FillDataService(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service() { 
                    Id = 1, 
                    Name = "Thuê xe máy", 
                    Price = 200000, Description = "200.000/lượt/24h, xe được bao xăng chạy thoải mái", 
                    CreatedTime = DateTime.Now, 
                    UpdatedTime = DateTime.Now 
                },
                new Service()
                {
                    Id = 2,
                    Name = "Lặn nhum",
                    Price = 50000,
                    Description = "50.000/lượt/người, được hỗ trợ kính lặn biển, vợt bắt nhum",
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now
                },
                new Service()
                {
                    Id = 3,
                    Name = "Chinh phục Ma Thiên Lãnh",
                    Price = 50000,
                    Description = "50.000/lượt/người, hướng dẫn leo núi, hỗ trợ nước uống",
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now
                }
            );
        }
    }
}
