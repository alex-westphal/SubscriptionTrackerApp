using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionTrackerApp.Models.ServiceType;
using SubscriptionTrackerApp.Models.ServiceType.Microsoft.AspNetCore.Mvc.Rendering;


namespace SubscriptionTrackerApp.Services.ServiceServices
{
    // public class IServiceService
    // {
        public interface IServiceService
        {

        public Task<string?> GetSubscriptionServiceListItemBySubscriptionIdAsync(int id);
        Task<bool> CreateServiceTypeAsync(ServiceTypeCreate request);
        Task<IEnumerable<ServiceTypeListItem>> GetServiceTypeListItems();
        Task<List<ServiceTypeListItem>> GetServiceTypeListItemsAsync();
        Task<bool> DeleteServiceTypeAsync(int id);
        Task<bool> ServiceTypeEditAsync(ServiceTypeEdit request);
    }
    }
// }