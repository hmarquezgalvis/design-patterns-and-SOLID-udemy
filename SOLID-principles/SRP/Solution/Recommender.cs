using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_principles.SRP.Solution
{
    public class Recommender
    {
        public IEnumerable<Movie> GetMoviesRecommended(Client client)
        {
            var moviesRecommended = new List<Movie>();
            foreach (var favorite in client.Favorites)
            {
                moviesRecommended.AddRange(DummyDB.GetMovieRecommendedByDirector(favorite.Director));
            }
            moviesRecommended = moviesRecommended.Where(x => !client.Favorites.Contains(x)).ToList();
            return moviesRecommended;
        }
    }
}
