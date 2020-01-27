using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmweb.Data;
using filmweb.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace filmweb.Controllers
{
    public class FilmController : Controller
    {
        private readonly DataContext db;
        public FilmController(DataContext context)
        {
            db = context;
        }

        // GET: Film
        public ActionResult Index(int id, FilmModel model)
        {
            var films = db.Films
                    .Include(f => f.Actors)
                        .ThenInclude(fa => fa.Actor)
                    .Include(f => f.Genres)
                        .ThenInclude(fg => fg.Genre)
                    .Include(f => f.Producers)
                        .ThenInclude(fp => fp.Producer)
                    .Include(f=>f.Comments)
                .ToList();
            //model.FilmsList = films;
            return View();
        }
    }
}