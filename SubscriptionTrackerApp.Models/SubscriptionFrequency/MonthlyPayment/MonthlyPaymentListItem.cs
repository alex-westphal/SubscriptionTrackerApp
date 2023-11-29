using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.SubscriptionFrequency.MonthlyPaymentMicrosoft.AspNetCore.Mvc.Rendering;

    public class MonthlyPaymentListItem
    {
         public int Id { get; set; }
        public string SubscriptionFrequency { get; set; } = string.Empty;
        DateTime RenewalDate {get; set;}
    }
