using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Movies
{
    /// <summary>
    /// A class representing a database of movies
    /// </summary>
    public static class MovieDatabase
    {
        private static List<Movie> movies;

        /// <summary>
        /// Loads the movie database from the JSON file
        /// </summary>
        public static List<Movie> FilterByMPAA(MovieDatabase.All, mpaa)
        {

        }

        public static List<Movie> All { get
            {
                if (movies is null) movies = new List<Movie>();
                using (StreamReader file = System.IO.File.OpenText("movies.json"))
                {
                    string json = file.ReadToEnd();
                    movies = JsonConvert.DeserializeObject<List<Movie>>(json);
                }
                return movies;
            } }

        public static List<Movie> Search(string term)
        {
            List<Movie> results = new List<Movie>();

            foreach (Movie movie in movies)
                if (movie.Title.Contains(term, StringComparison.OrdinalIgnoreCase)) results.Add(movie);

            return results;
        }
    }


}
