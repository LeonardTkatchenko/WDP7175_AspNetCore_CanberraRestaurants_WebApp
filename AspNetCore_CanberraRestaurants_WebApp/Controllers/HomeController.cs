﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCore_CanberraRestaurants_WebApp.Models;

namespace AspNetCore_CanberraRestaurants_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Restaurants()
        {
            return View();
        }

        public IActionResult Cuisines()
        {
            return View();
        }

        public IActionResult Dishes()
        {
            return View();
        }

        public IActionResult Prices()
        {
            return View();
        }

        public IActionResult Locations()
        {
            return View();
        }

        public IActionResult ContactAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
