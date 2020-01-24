using filmweb.Models;
using filmweb.Repositorys.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Repositorys
{
    public class SqlRepository : IUserRepository
    {
        [Inject]
        public DataContext Db { get; set; }
        public IQueryable<User> Users 
        {
            get { return Db.Users; }
        }

        public IQueryable<Comment> GetUserComment => throw new NotImplementedException();

        public IQueryable<Film> GetFavFilms(User user)
        {
            throw new NotImplementedException();
        }
    }
}
