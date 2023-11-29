
namespace SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;

public class SubscriptionServiceDelete
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Type { get; set; }
    public string Purpose { get; set; }
    public int SubscriptionFrequency { get; set; }
    decimal PriceOfSubscription { get; set; }
    DateTime RenewalDate { get; set; }
}
