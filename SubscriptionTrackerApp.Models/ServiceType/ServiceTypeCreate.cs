using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SubscriptionTrackerApp.Models.ServiceType;

public class ServiceTypeCreate
{
    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; }

    [Required]
    public int Priority { get; set; }

    public string Type { get; set; }

    public string Purpose { get; set; }

    public string SubscriptionFrequency { get; set; }

    [Required]
    public decimal PriceOfSubscription { get; set; }
}
