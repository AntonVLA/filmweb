using filmweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Repositorys
{
    interface IFilmIRepository
    {
        IQueryable<Film> Films { get; }

        
    }
}
