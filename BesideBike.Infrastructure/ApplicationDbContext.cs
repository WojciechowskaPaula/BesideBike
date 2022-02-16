using BesideBike.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BesideBike.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeType> BikeTypes { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            builder.Entity<Bike>()
               .HasOne<BikeType>(x => x.BikeType)
               .WithMany(x => x.Bikes)
               .HasForeignKey(x => x.BikeTypeId);

            builder.Entity<Order>()
                .HasOne<Bike>(x => x.Bike)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.BikeId);
        }
    }
}
