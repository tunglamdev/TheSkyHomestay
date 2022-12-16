using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.Configurations
{
    public class RoomConfig : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.AdultCapacity).IsRequired().HasDefaultValue(2);
            builder.Property(x => x.ChildCapacity).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.CreatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedTime).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
