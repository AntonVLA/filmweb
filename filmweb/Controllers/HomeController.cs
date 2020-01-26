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
using filmweb.Data;

namespace filmweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index(int page, HomeModel model)
        {
            var films = db.Films.Include(f => f.Actors.Select(a=>a.Actor)).Include(f => f.Genres.Select(g => g.Genre)).Include(f => f.Producers.Select(p=>p.Producer)).ToList();
            model.FilmsList = films;

            return View(model);
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
