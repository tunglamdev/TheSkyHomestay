using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class BillExtension
    {
        public static void FillDataBill(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>().HasData(
                new Bill()
                {
                    Id = 1,
                    TouristId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"),
                    CreatedTime = DateTime.Now
                },
                new Bill()
                {
                    Id = 2,
                    TouristId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"),
                    CreatedTime = DateTime.Now
                }
            );
        }
    }
}
