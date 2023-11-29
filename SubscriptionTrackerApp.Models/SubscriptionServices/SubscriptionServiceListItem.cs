using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

    public class SubscriptionServiceListItem
    {
        public int Id { get; set; }

        [Display(Name = "Name of Service")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Type of Service")]
        public string Type { get; set; } = string.Empty;

        [Display(Name = "Purpose of Service")]
        public string Purpose { get; set; } = string.Empty;

        [Display(Name = "Subscription Renewal Frequency of Service")]
        public string SubscriptionFrequency { get; set; } = string.Empty;

        [Display(Name = "Price of Subscription")]
        public decimal PriceOfSubscription { get; set; }

        public static implicit operator SubscriptionServiceListItem?(string? v)
        {
            throw new NotImplementedException();
        }



        // public static implicit operator SubscriptionServiceListItem?(string? v)
        // {
        //     throw new NotImplementedException();
        // }
    }
