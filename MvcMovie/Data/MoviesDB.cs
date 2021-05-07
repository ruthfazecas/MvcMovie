using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public static class MoviesDB
    {
        private static int AutoId = 0;

        public static List<MovieModel> Movies { get; } = new List<MovieModel>(); 

        public static void Create(MovieModel m) {
           
            m.Id = ++AutoId;
            Movies.Add(m);
        }

        public static void Update(int id, MovieModel m)
        {
            MovieModel old = Movies.FirstOrDefault(m => m.Id == id);
            if (old == null)
            {
                return;
            }

            old.Title = m.Title;
            old.Producer = m.Producer;
            old.Year = m.Year;
            old.Rating = m.Rating;
        }

        public static void Delete(int id)
        {
            MovieModel old = Movies.FirstOrDefault(m => m.Id == id);
            if (old == null)
            {
                return;
            }

            Movies.Remove(old);
        }
    }

}
