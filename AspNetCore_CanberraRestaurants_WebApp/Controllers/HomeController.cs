using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCore_CanberraRestaurants_WebApp.Models;
using AspNetCore_CanberraRestaurants_WebApp.Data;
using Microsoft.EntityFrameworkCore;


namespace AspNetCore_CanberraRestaurants_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Restaurants()
        {
            var allReviews = from result in _context.ReviewsForum
                                 orderby result.PostDate descending
                                 select result;

            return View(await allReviews.ToListAsync());
            //return View(await _context.ReviewsForum.ToListAsync());
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
