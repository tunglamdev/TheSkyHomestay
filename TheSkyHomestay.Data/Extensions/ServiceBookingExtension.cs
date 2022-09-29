using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class ServiceBookingExtension
    {
        public static void FillDataServiceBooking(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceBooking>().HasData(
                new ServiceBooking()
                {
                    BillId = 1,
                    ServiceId = 1,
                    Price = 200000,
                    Amount = 1,
                    Total = 200000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                },
                new ServiceBooking()
                {
                    BillId = 1,
                    ServiceId = 2,
                    Price = 50000,
                    Amount = 2,
                    Total = 100000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                },
                new ServiceBooking()
                {
                    BillId = 2,
                    ServiceId = 1,
                    Price = 200000,
                    Amount = 2,
                    Total = 400000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                }
            );
        }
    }
}
