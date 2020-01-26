using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class Film : FilmProperty
    {
        public IEnumerable<FilmGenre> Genres { get; set; }

        public IEnumerable<FilmActor> Actors { get; set; }

        public IEnumerable<FilmProducer> Producers { get; set; }

        public IEnumerable<FavoriteFilms> UserFav { get; set; }

        public Film()
        {
            Genres = new List<FilmGenre>();
            Actors = new List<FilmActor>();
            Producers = new List<FilmProducer>();
            UserFav = new List<FavoriteFilms>();
        }
    }

    public abstract class FilmProperty
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Producer : FilmProperty
    {
        public IEnumerable<FilmProducer> Films { get; set; }
        public Producer()
        {
            Films = new List<FilmProducer>();
        }
    }

    public class Genre : FilmProperty
    {
        public IEnumerable<FilmGenre> Films { get; set; }
        public Genre()
        {
            Films = new List<FilmGenre>();
        }
    }

    public class Actor : FilmProperty
    {
        public IEnumerable<FilmActor> Films { get; set; }
        public Actor() 
        {
            Films = new List<FilmActor>();
        } 
    }

    #region ManyToMany

    public abstract class FilmManyToMany
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }

    public class FilmActor : FilmManyToMany
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }

    public class FilmGenre : FilmManyToMany
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }

    public class FilmProducer : FilmManyToMany
    {
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }

    public class FavoriteFilms : FilmManyToMany
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
    #endregion
}
