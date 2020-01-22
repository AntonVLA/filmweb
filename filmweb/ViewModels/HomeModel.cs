using filmweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.ViewModels
{
    public class HomeModel
    {
        public IEnumerable<Film> FilmsList { get; set; }
    }
}
