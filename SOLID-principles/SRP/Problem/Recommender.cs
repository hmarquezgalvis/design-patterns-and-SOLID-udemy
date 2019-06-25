using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_principles.SRP.Problem
{
    public class Recommender
    {
        public IEnumerable<Movie> GetMoviesRecomended(Client client)
        {
            var moviesRecommended = new List<Movie>();
            foreach (var favorite in client.Favorites)
            {
                moviesRecommended.AddRange(DummyDB.GetMovieRecommendedByDirector(favorite.Director));
            }
            // moviesRecommended = moviesRecommended.Where(x => !client.Favorites.Contains(x)).ToList();
            return moviesRecommended;
        }

        public string ExportToCSV(Client client)
        {
            var movies = GetMoviesRecomended(client).Select(x => $"{x.Title},{x.Gender},{x.Director}");

            return string.Join("\n", movies);
        }
    }
}
