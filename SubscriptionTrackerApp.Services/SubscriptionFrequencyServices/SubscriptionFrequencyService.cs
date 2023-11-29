using Microsoft.EntityFrameworkCore;
using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Models.SubscriptionFrequency;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.Services.SubscriptionFrequencyServices;

    public class SubscriptionFrequencyService : ISubscriptionFrequencyService
    {
        private readonly SubscriptionDbContext _context;
        public SubscriptionFrequencyService(SubscriptionDbContext context)
        {
            _context = context;
        }
        public Task<List<SubscriptionFrequencyListItem>> GetSubscriptionFrequencyListItems(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SubscriptionFrequencyListItem>> GetAllSubscriptionFrequencyListItemsAsync(int id)
        {
            List<SubscriptionFrequencyListItem> subscriptionFrequencyListItems = await _context.SubscriptionFrequencies
            
            .Select(s => new SubscriptionFrequencyListItem()).ToListAsync();
            return subscriptionFrequencyListItems;
        }

    public Task<bool> GetSubscriptionFrequencyListItems()
    {
        throw new NotImplementedException();
    }

    public Task<bool> GetAllSubscriptionFrequencyListItemsAsync()
    {
        throw new NotImplementedException();
    }
}
