using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.SubscriptionFrequency.MonthlyPayment.Microsoft.AspNetCore.Mvc.Rendering;

    public class MonthlyPaymentCreate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        DateTime RenewalDate { get; set; }
    }
