using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace SubscriptionTrackerApp.Models.SubscriptionServices;


public class SubscriptionServiceCreate
{
    public int id { get; set; }
    
    public string Name { get; set; }

    public string Type { get; set; }
    public string Purpose { get; set; }
    public string SubscriptionFrequency { get; set; }
    public decimal PriceOfSubscription { get; set; }
    DateTime RenewalDate { get; set; }
}

