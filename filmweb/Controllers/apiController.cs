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

        //[HttpGet]
        //public JsonResult GetAllFilms()
        //{
        //    var films = db.Films;
        //    var model = new HomeViewModel(films);
        //    return Json(model.FilmsList);
        //}

        [HttpGet]
        public JsonResult GetAllFilms(string sortBy="id", bool asc=true)
        {
            switch(sortBy)
            {
                case "id":
                    if(asc)
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderBy(l => l.Id));
                    else
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderByDescending(l => l.Id));

                case "name":
                    if(asc)
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderBy(l => l.Name));
                    else
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderByDescending(l => l.Name));

                default:
                    return Json(new HomeViewModel(db.Films).FilmsList);

            }
            
        }
    }
}