using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Extensions
{
    public static class RoomBookingExtension
    {
        public static void FillDataRoomBooking(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomBooking>().HasData(
                new RoomBooking()
                {
                    BillId = 1,
                    RoomId = 1,
                    NumberOfAdult = 2,
                    NumberOfChild = 1,
                    CheckInDate = new DateTime(2022,09,29),
                    CheckOutDate = new DateTime(2022,09,30),
                    Price = 500000,
                    Total = 500000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                },
                new RoomBooking()
                {
                    BillId = 1,
                    RoomId = 3,
                    NumberOfAdult = 2,
                    NumberOfChild = 1,
                    CheckInDate = new DateTime(2022, 09, 29),
                    CheckOutDate = new DateTime(2022, 09, 30),
                    Price = 500000,
                    Total = 500000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                },
                new RoomBooking()
                {
                    BillId = 2,
                    RoomId = 4,
                    NumberOfAdult = 4,
                    NumberOfChild = 2,
                    CheckInDate = new DateTime(2022, 09, 29),
                    CheckOutDate = new DateTime(2022, 09, 30),
                    Price = 800000,
                    Total = 800000,
                    BookingTime = DateTime.Now,
                    CancelingTime = new DateTime(),
                }
            );
        }
    }
}
