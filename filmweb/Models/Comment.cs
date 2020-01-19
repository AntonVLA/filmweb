using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace filmweb.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
