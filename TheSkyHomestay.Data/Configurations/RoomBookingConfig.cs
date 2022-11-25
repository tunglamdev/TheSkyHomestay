using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Configurations
{
    public class RoomBookingConfig : IEntityTypeConfiguration<RoomBooking>
    {
        public void Configure(EntityTypeBuilder<RoomBooking> builder)
        {
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.CheckInDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CheckOutDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.BookingTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CancelingTime).IsRequired();
            builder.Property(x => x.IsCanceled).HasDefaultValue(false);
            builder.HasKey(c => new { c.BillId, c.RoomId });
        }
    }
}
