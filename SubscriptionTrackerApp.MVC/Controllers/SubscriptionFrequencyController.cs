using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Models.SubscriptionServices;
using SubscriptionTrackerApp.Models.SubscriptionServices.Microsoft.AspNetCore.Mvc.Rendering;
using SubscriptionTrackerApp.Services.ServiceServices;
using SubscriptionTrackerApp.Services.SubscriptionServices;
using SubscriptionTrackerApp.MVC;
using SubscriptionTrackerApp.Services.SubscriptionFrequencyServices;
using SubscriptionTrackerApp.Data.Entities;

// This is the controller for the Subscription frequency

namespace SubscriptionTrackerApp.MVC.Controllers
{
    public class SubscriptionFrequencyController : Controller
    {
        private readonly ISubscriptionFrequencyService _subscriptionFrequencyService;

        private readonly ISubscriptionUserService _subscriptionService;
        private readonly IServiceService _serviceService;
        private ISubscriptionUserService? subscriptionService;

        public SubscriptionFrequencyController(ISubscriptionFrequencyService subscriptionFrequencyService,
        IServiceService serviceService)
        {
            _subscriptionFrequencyService = subscriptionFrequencyService;
            _serviceService = serviceService;
            _subscriptionService = subscriptionService;
        }


    }
}