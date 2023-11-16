using Microsoft.AspNetCore.Mvc;

namespace SubscriptionTrackerApp.MVC.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}