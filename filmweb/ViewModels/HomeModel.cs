using filmweb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.ViewModels
{
    public class HomeModel
    {
        public List<FilmViewModel> FilmsList { get; set; }
        public HomeModel(DbSet<Film> films)
        {
            var filmsList = films.Include(f => f.Actors)
                        .ThenInclude(fa => fa.Actor)
                    .Include(f => f.Genres)
                        .ThenInclude(fg => fg.Genre)
                    .Include(f => f.Producers)
                        .ThenInclude(fp => fp.Producer)
                .ToList();
            foreach (Film film in films)
            {
                FilmsList.Add(new FilmViewModel(film));
            }
        }
    }
    public class FilmViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Produsers { get; set; }
        public List<Comment> Comments { get; set; }

        public FilmViewModel(Film film)
        {
            Id = film.Id;
            Name = film.Name;
            Genres = film.getFilmGenrs().Select(g=>g.Name).ToList();
            Actors = film.getFilmActors().Select(a => a.Name).ToList();
            Produsers = film.getFilmProducers().Select(p => p.Name).ToList();
            Comments = film.Comments.ToList();
        }
    }
}
