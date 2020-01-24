using filmweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Repositorys.Interfaces
{
    interface IUserRepository
    {
        IQueryable<User> Users { get; }

        IQueryable<Film> GetFavFilms(User user);

        IQueryable<Comment> GetUserComment { get; }
    }
}
