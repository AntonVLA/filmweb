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
using filmweb.Data;
using Microsoft.EntityFrameworkCore;

namespace filmweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public HomeController(DataContext context)
        {
            db = context;
        }

        public IActionResult Index(HomeModel model)
        {
            var films = db.Films
                    .Include(f => f.Actors)
                        .ThenInclude(fa=>fa.Actor)
                    .Include(f => f.Genres)
                        .ThenInclude(fg=>fg.Genre)
                    .Include(f => f.Producers)
                        .ThenInclude(fp=>fp.Producer)
                .ToList();
            model = new HomeModel(films);

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
