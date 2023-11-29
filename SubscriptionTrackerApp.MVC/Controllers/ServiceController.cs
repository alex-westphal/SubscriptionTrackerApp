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
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServicesMicrosoft.AspNetCore.Mvc.Rendering;

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
        List<SubscriptionServiceListItem> subscriptionServices = await _subscriptionService.SubscriptionServiceCreateAsync();
        return View(subscriptionServices);
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