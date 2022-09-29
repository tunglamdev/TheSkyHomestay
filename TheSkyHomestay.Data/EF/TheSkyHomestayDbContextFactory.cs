using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSkyHomestay.Data.EF
{
    public class TheSkyHomestayDbContextFactory : IDesignTimeDbContextFactory<TheSkyHomestayDbContext>
    {
        public TheSkyHomestayDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Default");

            var optionsBuilder = new DbContextOptionsBuilder<TheSkyHomestayDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new TheSkyHomestayDbContext(optionsBuilder.Options);
        }
    }
}
