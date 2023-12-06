using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.Services.SubscriptionServices;


public class SubscriptionUserService : ISubscriptionUserService
{
    private readonly SubscriptionDbContext _context;
    public SubscriptionUserService(SubscriptionDbContext context)
    {
        _context = context;
    }

    public Task<List<SubscriptionServiceListItem>> GetSubscriptionServiceListItems()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<bool> SubscriptionServiceCreateAsync(SubscriptionServiceCreate model)
    {
        SubscriptionService subscriptionService = new SubscriptionService()
        {
            Name = model.Name,
            Type = model.Type,
            Purpose = model.Purpose,
            SubscriptionFrequency = model.SubscriptionFrequency,
            PriceOfSubscription = model.PriceOfSubscription,
        };

        _context.SubscriptionServices.Add(subscriptionService);
        return await _context.SaveChangesAsync() == 1;
    }

    public async Task<List<SubscriptionServiceListItem>> GetAllSubscriptionServiceListItemsAsync(int id)
    {
        List<SubscriptionServiceListItem> subscriptionServices = await _context.ServiceTypes
        .Select(s => new SubscriptionServiceListItem()
        {
            Name = s.Name,
            Type = s.Type,
            Purpose = s.Purpose,
            SubscriptionFrequency = s.SubscriptionFrequency,
            PriceOfSubscription = s.PriceOfSubscription
        }).ToListAsync();
        return subscriptionServices;
    }

    public async Task<SubscriptionServiceListItem?> GetSubscriptionServiceListItemBySubscriptionIdAsync(int id)
    {
        SubscriptionService? subscriptionService = await _context.SubscriptionServices
        .FirstOrDefaultAsync(s => s.Id == id);

        return subscriptionService is null ? null : new SubscriptionServiceListItem()
        {
            Name = subscriptionService.Name,
            Type = subscriptionService.Type,
            Purpose = subscriptionService.Purpose,
            SubscriptionFrequency = subscriptionService.SubscriptionFrequency,
            PriceOfSubscription = subscriptionService.PriceOfSubscription
        };
    }



    [HttpDelete]
    public async Task<bool> DeleteSubscriptionServiceAsync(int id)
    {
        var subscriptionServices = await _context.SubscriptionServices.FindAsync(id);
        if (subscriptionServices == null)
            return false;

        _context.SubscriptionServices.Remove(subscriptionServices);
        return await _context.SaveChangesAsync() == 1;
    }

    public async Task<List<SubscriptionServiceListItem>> GetAllSubscriptionServiceListItemsAsync()
    {
        var subscriptionServiceListItems = await _context.SubscriptionServices
            .Select(s => new SubscriptionServiceListItem()
            {
                Id = s.Id,
                Name = s.Name,
                Type = s.Type,
                Purpose = s.Purpose,
                SubscriptionFrequency = s.SubscriptionFrequency,
                PriceOfSubscription = s.PriceOfSubscription
            })
            .ToListAsync();
         return subscriptionServiceListItems;
    }

    public Task<List<SubscriptionServiceListItem>> GetSubscriptionServiceListItemBySubscriptionIdAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<SubscriptionServiceListItem>> SubscriptionServiceCreateAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> SubscriptionServiceEditAsync(SubscriptionServiceEdit model)
    {
        throw new NotImplementedException();
    }
}

