﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace FrontRayones.Controllers
{
    public partial class DashboardLayoutController : Controller
    {
        public ActionResult DashboardLayoutFeatures()
        {
				return View();
        }
    }
}
