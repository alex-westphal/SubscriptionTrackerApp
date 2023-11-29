using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionTrackerApp.Data.Entities;

namespace SubscriptionTrackerApp.Data
{
    public class SubscriptionDbContext : DbContext
    {
        public SubscriptionDbContext()
        {

        }

        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options)
            : base(options)
        {
        }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<SubscriptionFrequency> SubscriptionFrequencies { get; set; }
        public DbSet<SubscriptionService> SubscriptionServices { get; set; }


        // public DbSet<ServiceType> ServiceTypes {get; set;}

    }
}