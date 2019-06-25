using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_principles.SRP
{
    public class DummyDB
    {

        private static string GENDER_FANTASTIC = "Fantasy";
        private static string GENDER_WAR = "War";
        private static string DIRECTOR_SPIELBERG = "Spielberg";

        public static Movie ET = new Movie { Title = "ET", Gender = GENDER_FANTASTIC, Director = DIRECTOR_SPIELBERG };

        public static Movie PRIVATE_RYAN = new Movie { Title = "Saving Private Ryan", Gender = GENDER_WAR, Director = DIRECTOR_SPIELBERG };

        public static Client JOHN = new Client { Name = "John Smith", Favorites = new List<Movie> { ET } };

        private static IEnumerable<Movie> ALL = new List<Movie> { ET, PRIVATE_RYAN };

        public static IEnumerable<Movie> GetMovieList()
        {
            return ALL;
        }

        public static IEnumerable<Movie> GetMovieRecommendedByDirector(string director)
        {
            return ALL.Where(x => x.Director.Equals(director));
        }

        public static Client GetClientSample()
        {
            return JOHN;
        }

    }
}
