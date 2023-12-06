



using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SubscriptionTrackerApp.Models.ServiceType;

public class ServiceTypeCreate
{
    [Required]
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [Required]
    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }
    
    [JsonPropertyName("subscription_frequency")]
    public string SubscriptionFrequency { get; set; }

    [JsonPropertyName("price_of_subscription")] [Required]
    public decimal PriceOfSubscription { get; set; }
}
