using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;
using filmweb.Data;
using filmweb.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace filmweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class apiController : ControllerBase
    {
        private readonly DataContext db;
        public apiController(DataContext context)
        {
            db = context;
        }

        [HttpGet("api/AllFilms")]
        public ActionResult GetAllFilms()
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
            return  model.FilmsList;
        }
    }
}