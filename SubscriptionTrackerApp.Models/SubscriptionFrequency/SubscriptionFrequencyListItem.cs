using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.SubscriptionFrequency
{
    public class SubscriptionFrequencyListItem
    {
        public int Id { get; set; }

        [Display(Name = "Frequency of Subscription Renewal")]
        public string SubscriptionFrequency { get; set; } = string.Empty;
        public string Name { get; set; }
        DateTime RenewalDate {get; set;}
    }
}