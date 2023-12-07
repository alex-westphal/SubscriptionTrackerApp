using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Models.ServiceType;
using SubscriptionTrackerApp.Models.ServiceType.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServices;

namespace SubscriptionTrackerApp.Services.ServiceServices
{
    public class ServiceServices : IServiceService
    {
        private readonly SubscriptionDbContext _context;

        public ServiceServices(SubscriptionDbContext context)
        {
            _context = context;
        }


        public async Task<bool> CreateServiceTypeAsync(ServiceTypeCreate model)
        {
            ServiceType serviceType = new ServiceType()
            {
                Name = model.Name,
                Description = model.Description,
                Priority = model.Priority,
                Type = model.Type,
                Purpose = model.Purpose,
                SubscriptionFrequency = model.SubscriptionFrequency,
                PriceOfSubscription = model.PriceOfSubscription,
            };

            _context.ServiceTypes.Add(serviceType);
            return await _context.SaveChangesAsync() == 1;
        }

        public Task<IEnumerable<ServiceTypeListItem>> GetServiceTypeListItems()
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<List<ServiceTypeListItem>> GetServiceTypeListItemsAsync()
        {
            var serviceTypeListItem = await _context.ServiceTypes
            .Select(s => new ServiceTypeListItem()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Priority = s.Priority,
            })
            .ToListAsync();
            return serviceTypeListItem;
        }

        public async Task<bool> ServiceTypeEditAsync(ServiceTypeEdit model)
        {
            ServiceType serviceType = new ServiceType()
            {
                Name = model.Name,
                Description = model.Description,
                Priority = model.Priority,
            };
            _context.ServiceTypes.Add(serviceType);
            return await _context.SaveChangesAsync() == 1;
        }


        [HttpDelete]
        public async Task<bool> DeleteServiceTypeAsync(int id)
        {
            var serviceTypeToBeRemoved = await _context.ServiceTypes.FindAsync(id);
            _context.ServiceTypes.Remove(serviceTypeToBeRemoved);
            _context.SaveChanges();
            return true;
        }


        public Task<string?> GetSubscriptionServiceListItemBySubscriptionIdAsync(int id)
        {
            throw new NotImplementedException();
        }


    }
}
