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
        [HttpGet("film/{id:int}")]
        public ActionResult Index(int? id, FilmViewModel model)
        {
            var film = db.Films
                    .Include(f => f.Actors)
                        .ThenInclude(fa => fa.Actor)
                    .Include(f => f.Genres)
                        .ThenInclude(fg => fg.Genre)
                    .Include(f => f.Producers)
                        .ThenInclude(fp => fp.Producer)
                    .Include(f => f.Comments)
                    .Include(f=>f.UserFav)
                        .ThenInclude(f=>f.User)
                    .Where(f => f.Id == id).First();
                        
            model = new FilmViewModel(film);
            return View(model);
        }
    }
}