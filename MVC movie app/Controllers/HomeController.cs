using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_movie_app.Areas.Identity.Data;
using MVC_movie_app.Models;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_movie_app.Data;
using MVC_movie_app.Areas.Identity.Data;
using MVC_movie_app.Models;
using Microsoft.AspNetCore.Identity;


namespace MVC_movie_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly MVC_movie_appContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<MVC_movie_appUser> _userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<MVC_movie_appUser> userManager, MVC_movie_appContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
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