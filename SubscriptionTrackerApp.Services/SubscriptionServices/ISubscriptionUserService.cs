using Microsoft.AspNetCore.Mvc;
using SubscriptionTrackerApp.Models;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.Services.SubscriptionServices;

public interface ISubscriptionUserService 
{
    Task<bool> SubscriptionServiceCreateAsync(SubscriptionServiceCreate request);
    Task<List<SubscriptionServiceListItem>> GetAllSubscriptionServiceListItemsAsync();
    Task<List<SubscriptionServiceListItem>> GetSubscriptionServiceListItemBySubscriptionIdAsync();

    Task<bool> SubscriptionServiceEditAsync( SubscriptionServiceEdit request);
    Task<bool> DeleteSubscriptionServiceAsync(int id);
    Task<List<SubscriptionServiceListItem>> SubscriptionServiceCreateAsync();
}