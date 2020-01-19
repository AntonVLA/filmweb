using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class Film : FilmProperty
    {
        public List<FilmGenre> Genres { get; set; }

        public List<FilmActor> Actors { get; set; }

        public List<FilmProducer> Producers { get; set; }

        public List<FavoriteFilms> UserFav { get; set; }
    }

    public abstract class FilmProperty
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Producer : FilmProperty
    {
        public List<FilmProducer> Films { get; set; }
    }

    public class Genre : FilmProperty
    {
        public List<FilmGenre> Films { get; set; }
    }

    public class Actor : FilmProperty
    {
        public List<FilmActor> Films { get; set; }
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
