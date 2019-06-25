using System;
using System.Collections.Generic;

namespace SOLID_principles.SRP
{
    public class Client
    {
        public string Name { get; set; }
        public IEnumerable<Movie> Favorites { get; set; }
    }
}
