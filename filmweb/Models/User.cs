using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public List<Comment> Comments { get; set; }

        public List<FavoriteFilms> FavoriteFilms { get; set; }
    }
}
