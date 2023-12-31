using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SubscriptionTrackerApp.Data.Entities;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Services.ServiceServices;
using SubscriptionTrackerApp.Services.SubscriptionFrequencyServices;
using SubscriptionTrackerApp.Services.SubscriptionServices;
using SubscriptionTrackerApp.Models.ServiceType;
using SubscriptionTrackerApp.Models.ServiceType.Microsoft.AspNetCore.Mvc.Rendering;

namespace SubscriptionTrackerApp.MVC.Controllers
{
    public class ServiceTypeController : Controller
    {
        

        private readonly ISubscriptionUserService _subscriptionUserService;

        private readonly ISubscriptionFrequencyService _subscriptionFrequencyService;
        private readonly IServiceService _serviceService;
        public ServiceTypeController(ISubscriptionUserService subscriptionUserService,
            IServiceService serviceService)
        {
            _serviceService = serviceService;
            _subscriptionUserService = subscriptionUserService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<ServiceTypeListItem> serviceTypes = await _serviceService.GetServiceTypeListItemsAsync();
            return View(serviceTypes);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServiceTypeCreate model)
        {
            if (!ModelState.IsValid)
                return View(model);

            await _serviceService.CreateServiceTypeAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(ServiceTypeEdit model)
        {
            if(!ModelState.IsValid)
                return View(model);

        await _serviceService.ServiceTypeEditAsync(model);
        return RedirectToAction(nameof(Index));
        }

        [HttpDelete]

        public async Task<IActionResult> Delete()
        {
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            // if(!ModelState.IsValid)
                // return View(int);

            await _serviceService.DeleteServiceTypeAsync(id);
            return RedirectToAction(nameof(Index));
        }



        public async Task<bool> DeleteServiceTypeAsync(int id)
        {
            return true;
        }



    }
}
