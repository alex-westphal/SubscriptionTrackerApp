using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.Services.SubscriptionServices;

public interface ISubscriptionUserService 
{
    Task<bool> SubscriptionServiceCreateAsync(SubscriptionServiceCreate model);
    Task<List<SubscriptionServiceListItem>> GetAllSubscriptionServiceListItemsAsync();
    Task<List<SubscriptionServiceListItem>> GetSubscriptionServiceListItemBySubscriptionIdAsync();

    Task<bool> DeleteSubscriptionServiceAsync(int id);
    Task<List<SubscriptionServiceListItem>> SubscriptionServiceCreateAsync();
}