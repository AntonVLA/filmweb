using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using filmweb.Models;
using filmweb.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace filmweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index(int page)
        {
            HomeModel ivm = new HomeModel { FilmsList = from film in db.Films.Skip(page * 3).Take(3) 
                                                         from genre in db.Genres 
                                                         select film
            };
            return View(ivm);
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
