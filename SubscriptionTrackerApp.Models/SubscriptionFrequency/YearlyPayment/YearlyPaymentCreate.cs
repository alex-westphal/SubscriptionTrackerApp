using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.SubscriptionFrequency.YearlyPayment.Microsoft.AspNetCore.Mvc.Rendering;

    public class YearlyPaymentCreate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        DateTime RenewalDate { get; set; }
    }
