using MvcMovie.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieModel
    {

        public int Id { get; set; }

        public string Title { get; set;}

        public string Producer { get; set; }

        public int Year { get; set; }

        public Ratings Rating { get; set; }



    }
}
