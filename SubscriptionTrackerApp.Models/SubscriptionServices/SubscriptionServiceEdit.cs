
namespace SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

    public class SubscriptionServiceEdit
    {
        public int Id {get; set;}

        public string Name {get; set;}

        public int ServiceType {get; set;}

        public string Purpose {get; set;}

        public int SubscriptionFrequency {get; set;}

        decimal PriceOfSubscription {get; set;}

        DateTime RenewalDate {get; set;}
    }
