﻿using Microsoft.AspNetCore.Mvc;

namespace Tracker.Controllers
{
    public class SeedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
