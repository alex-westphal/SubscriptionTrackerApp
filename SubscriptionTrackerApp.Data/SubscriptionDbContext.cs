using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Data
{
    public class SubscriptionDbContext : DbContext
    {
        public SubscriptionDbContext()
        {
        }

        public SubscriptionDbContext(DbContextOptions<SubscriptionDbContext> options)
            :base (options)
            {
            }

            // public DbSet<ServiceType> ServiceTypes {get; set;}

    }
}