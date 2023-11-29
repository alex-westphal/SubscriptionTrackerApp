using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Services.SubscriptionFrequencyServices
{
    public interface ISubscriptionFrequencyService
    {
        Task<bool> GetSubscriptionFrequencyListItems();
        Task<bool> GetAllSubscriptionFrequencyListItemsAsync();
        // Task<bool>
    }
}