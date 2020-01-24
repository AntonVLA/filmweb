using filmweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Repositorys.Interfaces
{
    interface IGenreRepository
    {
        IQueryable<Genre> Genres { get; }

        IQueryable<Film> GetGenrFilms { get; }

    }
}
