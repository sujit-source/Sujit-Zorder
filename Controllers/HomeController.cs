using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using New_zOrder.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace New_zOrder.Controllers
{
    public class HomeController : Controller
    {
        

        private readonly IConfiguration _configuration;

        private readonly IWebHostEnvironment _env;
        public HomeController(IConfiguration configuration, IWebHostEnvironment env)
        {
            _env = env;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("~/hrm")]
        public IActionResult HRM()
        {
            return View();
        }
        [Route("~/aboutus")]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("~/blogs")]
        public IActionResult Blogs()
        {
            return View();
        }
        [Route("~/contacts")]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
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
