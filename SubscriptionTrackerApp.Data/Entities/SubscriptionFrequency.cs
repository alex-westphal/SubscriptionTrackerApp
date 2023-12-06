using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Data.Entities
{
    public class SubscriptionFrequency 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private string subscriptionFrequency;

        public string GetSubscriptionFrequency()
        {
            return subscriptionFrequency;
        }

        public void SetSubscriptionFrequency(string value)
        {
            subscriptionFrequency = value;
        }
    }
}