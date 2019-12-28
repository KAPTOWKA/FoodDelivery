﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FoodDelivery.Domain.Entities;
using FoodDelivery.WebUI.Infrastructure.Binders;

namespace FoodDelivery.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
			ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
		}
    }
}
