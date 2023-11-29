using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.Services.ServiceServices
{
    public class ServiceServices : IServiceService
    {
        private readonly SubscriptionDbContext _context;

        public ServiceServices(SubscriptionDbContext context)
        {
            _context = context;
        }

        public async Task<List<SubscriptionServiceListItem>> GetAllServicesAsync()
        {
            List<SubscriptionServiceListItem> subscriptionServices = await _context.ServiceTypes
            .Select(s => new SubscriptionServiceListItem()
            {
                Id = s.Id,
                Name = s.Name,
                Type = s.Type,
                Purpose = s.Purpose,
                SubscriptionFrequency = s.SubscriptionFrequency,
                PriceOfSubscription = s.PriceOfSubscription
            }).ToListAsync();
            return subscriptionServices;
        }




        public async Task<bool> SubscriptionServiceCreateAsync(SubscriptionServiceCreate model)
        {
            ServiceType serviceType = new ServiceType()
            {

                Name = model.Name,
                Type = model.Type,
                Purpose = model.Purpose,
                SubscriptionFrequency = model.SubscriptionFrequency,
                PriceOfSubscription = model.PriceOfSubscription,
            };

            _context.ServiceTypes.Add(serviceType);
            return await _context.SaveChangesAsync() == 1;
        }
    }

}

