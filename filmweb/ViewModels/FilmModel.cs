using filmweb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.ViewModels
{
    public class FilmModel
    {
        public IEnumerable<Comment> CommentList { get; set; }

    }
}
