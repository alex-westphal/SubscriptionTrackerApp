using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Data.Entities
{
    public class SubscriptionService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Purpose { get; set; }
        public string SubscriptionFrequency { get; set; }
        public decimal PriceOfSubscription { get; set; }
        DateTime RenewalDate { get; set; }

    }
}