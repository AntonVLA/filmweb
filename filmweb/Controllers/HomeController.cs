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
using System.Data.Entity;

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
            var films = db.Films.Skip(page * 3).Take(3);
            var _ = db.Users.Where(u => u.Id == 1).SelectMany(u => u.FavoriteFilms);
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
