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

        public async Task<List<SubscriptionFrequencyListItem>> GetAllSubscriptionFrequencyListItemsAsync()
        {
           var subscriptionFrequencyListItems = await _context.SubscriptionFrequencies
            .Select(s => new SubscriptionFrequencyListItem()
            {
                Name = s.Name,
                SubscriptionFrequency = s.GetSubscriptionFrequency(),
            })
            .ToListAsync();
            return subscriptionFrequencyListItems;
        }

    public Task<bool> GetSubscriptionFrequencyListItems()
    {
        throw new NotImplementedException();
    }

    Task<bool> ISubscriptionFrequencyService.GetAllSubscriptionFrequencyListItemsAsync()
    {
        throw new NotImplementedException();
    }
}
