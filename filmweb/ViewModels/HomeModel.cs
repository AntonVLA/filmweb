using filmweb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.ViewModels
{
    public class HomeModel
    {
        public List<FilmViewModel> FilmsList { get; set; }
        public HomeModel(List<Film> films)
        {
            FilmsList = new List<FilmViewModel>();
            foreach(Film film in films)
            {
                this.FilmsList.Add(new FilmViewModel(film));
            }
        }

        public HomeModel()
        {
            
        }
    }
    public class FilmViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Genres { get; set; }
        public List<string> Actors { get; set; }
        public List<string> Produsers { get; set; }

        public FilmViewModel(Film film)
        {
            Id = film.Id;
            Name = film.Name;
            Genres = film.getFilmGenrs().Select(g=>g.Name).ToList();
            Actors = film.getFilmActors().Select(a => a.Name).ToList();
            Produsers = film.getFilmProducers().Select(p => p.Name).ToList();
        }
    }
}
