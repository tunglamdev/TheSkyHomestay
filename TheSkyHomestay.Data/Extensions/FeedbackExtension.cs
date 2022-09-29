using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class FeedbackExtension
    {
        public static void FillDataFeedback(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback()
                {
                    Id = 1,
                    TouristId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"),
                    RoomId = 1,
                    Vote = 5,
                    Comment = "Phòng rất đẹp! Anh chủ rất dễ thương luôn!",
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                },
                new Feedback()
                {
                    Id = 2,
                    TouristId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"),
                    RoomId = 3,
                    Vote = 5,
                    Comment = "Phòng rất đẹp! Anh chủ rất dễ thương luôn!",
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now,
                }
            );
        }
    }
}
