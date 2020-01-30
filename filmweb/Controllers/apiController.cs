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
    [Route("api/[controller]")]
    [ApiController]
    public class ApiFilmController : Controller
    {
        private readonly DataContext db;
        public ApiFilmController(DataContext context)
        {
            db = context;
        }

        [HttpGet]
        public JsonResult GetAllFilms()
        {
            var films = db.Films
                    .Include(f => f.Actors)
                        .ThenInclude(fa => fa.Actor)
                    .Include(f => f.Genres)
                        .ThenInclude(fg => fg.Genre)
                    .Include(f => f.Producers)
                        .ThenInclude(fp => fp.Producer)
                .ToList();
            var model = new HomeModel(films);
            return  Json(model.FilmsList);
        }
    }
}