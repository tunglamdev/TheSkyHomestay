using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSkyHomestay.Data.Configurations;
using TheSkyHomestay.Data.Extensions;
using TheSkyHomestay.Data.Models;

namespace TheSkyHomestay.Data.EF
{
    public class TheSkyHomestayDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public DbSet<Room> Rooms { set; get; }
        public DbSet<RoomCategory> RoomCategories { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserRole> UserRole { set; get; }
        public DbSet<Service> Services { set; get; }
        public DbSet<RoomBooking> RoomBookings { set; get; }
        public DbSet<ServiceBooking> ServiceBookings { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Bill> Bills { set; get; }
        public DbSet<RoomImage> RoomImages { set; get; }
        public TheSkyHomestayDbContext(DbContextOptions<TheSkyHomestayDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API in config file
            modelBuilder
                .ApplyConfiguration(new RoomConfig())
                .ApplyConfiguration(new RoomCategoryConfig())
                .ApplyConfiguration(new ServiceConfig())
                .ApplyConfiguration(new UserConfig())
                .ApplyConfiguration(new RoomBookingConfig())
                .ApplyConfiguration(new ServiceBookingConfig())
                .ApplyConfiguration(new FeedbackConfig())
                .ApplyConfiguration(new RoomImageConfig())
                .ApplyConfiguration(new BillConfig());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            // Data seeding in ModelBuilderExtenions
            modelBuilder.FillDataRoom();
            modelBuilder.FillDataRoomCategory();
            modelBuilder.FillDataService();
            modelBuilder.FillDataUser();
            modelBuilder.FillDataFeedback();
            modelBuilder.FillDataBill();
            modelBuilder.FillDataRoomBooking();
            modelBuilder.FillDataServiceBooking();
            modelBuilder.FillDataRoomImage();
        }
    }
}
