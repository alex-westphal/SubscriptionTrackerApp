using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SubscriptionTrackerApp.Data;
using SubscriptionTrackerApp.MVC;
using SubscriptionTrackerApp.Services.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using SubscriptionTrackerApp.Services.ServiceServices;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models;

// This is the controller for the Subscription Services
namespace SubscriptionTrackerApp.MVC.Controllers
{
    public class ServiceController : Controller
    {
        
        private readonly IServiceService _service;
        private readonly ISubscriptionUserService _subscriptionService;

        public ServiceController(IServiceService service,
        ISubscriptionUserService subscriptionService)
        {
            _service = service;
            _subscriptionService = subscriptionService;
        }


    public async Task<IActionResult> Create()
    {
        return View();
    }
     public async Task<IActionResult> Create(SubscriptionServiceCreate model)
    {
       if (!ModelState.IsValid)
                return View(model);

            await _subscriptionService.SubscriptionServiceCreateAsync(model);
            return RedirectToAction(nameof(Index));
    }



        public async Task<IActionResult> Index()
    {
        List<SubscriptionServiceListItem> subscriptionServices = await _subscriptionService.GetAllSubscriptionServiceListItemsAsync();
        return View(subscriptionServices);
    }

        // public IActionResult Index()
        // {
        //     return View();
        // }
        // private ISubscriptionUserService _subscriptionUserService;
        // public ServiceController(ISubscriptionUserService subscriptionUserService);
    }
}