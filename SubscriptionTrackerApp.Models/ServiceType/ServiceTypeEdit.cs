using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionTrackerApp.Models.ServiceType.Microsoft.AspNetCore.Mvc.Rendering;

    public class ServiceTypeEdit
    {
        public int Id {get; set;}
        public string Name {get; set;}

        public string Description {get; set;}

        public int Priority {get; set;}
    }
