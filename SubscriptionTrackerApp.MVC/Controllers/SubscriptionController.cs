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
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionUserService _subscriptionService;
        private readonly IServiceService _serviceService;

        public SubscriptionController(ISubscriptionUserService service,
        IServiceService serviceService)
        {
            _subscriptionService = service;
            _serviceService = serviceService;
        }
        public async Task<IActionResult> Index()
        {
            List<SubscriptionServiceListItem> subscriptionServices = await _subscriptionService.GetAllSubscriptionServiceListItemsAsync();
            return View(subscriptionServices);
        }

        // public async Task<IActionResult> Create()
        // {
        //     List<SubscriptionServiceListItem> subscriptionServiceListItems = await _subscriptionService.GetAllSubscriptionServiceListItemsAsync();

        //     IEnumerable<SelectListItem> selectListItems = SelectListItems
        //     .Select(s => SelectListItem);
        //     {

        //     }
        //         SubscriptionServiceCreate model = new SubscriptionServiceCreate();
        //     model.SelectListItems = selectListItems;
        
        //     return View(model);      
        // }

        // private SelectListItem SelectListItem()
        // {
        //     throw new NotImplementedException();
        // }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(SubscriptionServiceCreate model)
        {
            if(!ModelState.IsValid)
            return View(model);

            await _subscriptionService.SubscriptionServiceCreateAsync(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> SubscriptionService(int id)
        {
            if(!ModelState.IsValid)
            return View();

            var subscriptionService = await _serviceService.GetSubscriptionServiceListItemBySubscriptionIdAsync(id);

            if (subscriptionService == null)
            return RedirectToAction(nameof(Index));

            var subscriptionService1 = await _serviceService.GetSubscriptionServiceListItemBySubscriptionIdAsync(id);
            ViewBag.SubscriptionService = subscriptionService;

            return View(subscriptionService1);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            if(!ModelState.IsValid)
            return View();

            var subscriptionService = await _serviceService.GetSubscriptionServiceListItemBySubscriptionIdAsync(id);
            
            if (subscriptionService == null)
                return RedirectToAction(nameof(Index));

                return View(subscriptionService);
        }

    }
}