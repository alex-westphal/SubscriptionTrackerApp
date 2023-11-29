

namespace SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;


public class SubscriptionServiceCreate
{
    public int id { get; set; }
    
    public string Name { get; set; }

    public string Type { get; set; }
    public string Purpose { get; set; }
    public string SubscriptionFrequency { get; set; }
    public decimal PriceOfSubscription { get; set; }
    // public IEnumerable<Microsoft.AspNetCore.Mvc.Rendering> SelectListItems { get; set; }

    // public ICollection<SubscriptionTrackerApp.Data.Entities.SubscriptionService> SubscriptionServices { get; set; }
    // public IEnumerable<SelectListItem> SelectListItems {get; set;} = new List<SelectListItem>();
    DateTime RenewalDate { get; set; }
}

