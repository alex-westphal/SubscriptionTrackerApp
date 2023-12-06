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







        // public async Task<ServiceTypeListItem?> CreateServiceTypeAsync(ServiceTypeCreate request)
        // {
        //     ServiceTypeEntity entity = new()
        //  {
        //     Id = request.
        //     Name = request.Name,
        //     Description = request.Description,
        //     Priority = request.Priority,
        //     Type = request.Type,
        //     Purpose = request.Purpose,
        //     SubscriptionFrequency = request.SubscriptionFrequency,
        //     PriceOfSubscription = request.PriceOfSubscription
        //  };

        //  _dbContext.Notes.Add(entity);
        //  var numberOfChanges = await _context.SaveChangesAsync();

        // if(numberOfChanges !=1)
        //     return null;

        //    ServiceTypeListItem response = new()
        //    {
        //     Id = entity.Id,
        //     Name = entity.Name,
        //     Description = entity.Description,
        //     Priority = entity.Priority,
        //     Type = entity.Type,
        //     Purpose = entity.Purpose,
        //     SubscriptionFrequency = entity.SubscriptionFrequency,
        //     PriceOfSubscription = entity.PriceOfSubscription
        //    };




        // throw new NotImplementedException();


        // internal class CreateServiceTypeAsync
        // {
        // }
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

        




        //     public async Task<bool> ServiceTypeCreateAsync(ServiceTypeCreate model)
        //     {
        //         ServiceType serviceType = new ServiceType()
        //         {

        //             Name = model.Name,
        //             Type = model.Type,
        //             Purpose = model.Purpose,
        //             SubscriptionFrequency = model.SubscriptionFrequency,
        //             PriceOfSubscription = model.PriceOfSubscription,
        //         };

        //         _context.ServiceTypes.Add(serviceType);
        //         return await _context.SaveChangesAsync() == 1;
        //     }

        //     Task<ServiceTypeListItem?> IServiceService.CreateServiceTypeAsync(ServiceTypeCreate request)
        //     {
        //         throw new NotImplementedException();
        //     }
        // }

        internal class ServiceTypeEntity
        {
        }
        [HttpDelete]
        public async Task<bool> DeleteServiceTypeAsync(int id)
        {
            return true;
        }

        public Task<string?> GetSubscriptionServiceListItemBySubscriptionIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
