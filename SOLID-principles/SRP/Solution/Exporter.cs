using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_principles.SRP.Solution
{
    public class Exporter
    {
        public string ExportToCSV(IEnumerable<Movie> movies)
        {
            return string.Join("\n", movies.Select(x => $"{x.Title},{x.Director},{x.Gender}"));
        }
    }
}
