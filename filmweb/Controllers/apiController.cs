using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filmweb.Data;
using filmweb.Models;
using filmweb.ViewModels;
using filmweb.ViewModels.post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace filmweb.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class ApiFilmController : Controller
    {
        private readonly DataContext db;
        public ApiFilmController(DataContext context)
        {
            db = context;
        }

        [HttpGet("{filmid}")]
        public JsonResult GetComments(int filmid)
        {
            return Json(db.Comments.Where(c => c.FilmId == filmid).Select(c => new { c.Text, c.User.Email }));
        }

        [HttpPost]
        public void AddComment(AddCommentViewModel model)
        {
            db.Comments.Update(new Comment { Text = model.commenttext,
                FilmId = model.filmid, UserId = db.Users.Where(u => u.Email == User.Identity.Name).Select(u => u.Id).FirstOrDefault()
            });
            db.SaveChanges();
        }

        [HttpPost]
        public JsonResult GetAllFilms(FilterViewModel model)
        {
            switch(model.sortColumn)
            {
                case "id":
                    if(model.sortOrder)
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderBy(l => l.Id));
                    else
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderByDescending(l => l.Id));

                case "name":
                    if(model.sortOrder)
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderBy(l => l.Name));
                    else
                        return Json(new HomeViewModel(db.Films).FilmsList.OrderByDescending(l => l.Name));

                default:
                    return Json(new HomeViewModel(db.Films).FilmsList);

            }
            
        }
    }
}