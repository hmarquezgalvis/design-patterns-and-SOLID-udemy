using System;
using System.Linq;
using SOLID_principles.SRP;
using SOLID_principles.SRP.Solution;
using Xunit;

namespace SOLID_principles_Test
{
    public class SRP_Tests
    {
        [Fact]
        public void MoviesRecomended()
        {
            var r = new SOLID_principles.SRP.Solution.Recommender();

            var movies = r.GetMoviesRecommended(DummyDB.JOHN);

            Assert.False(movies.Contains(DummyDB.ET));
        }

        [Fact]
        public void MoviewsRecommendedExportFormat()
        {
            var r = new SOLID_principles.SRP.Solution.Recommender();
            var export = new Exporter();

            var csv = export.ExportToCSV(r.GetMoviesRecommended(DummyDB.JOHN));

            string expected = "Saving Private Ryan,Spielberg,War";

            Assert.Equal(expected, csv);
        }
    }
}
