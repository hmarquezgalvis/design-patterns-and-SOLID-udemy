using System;
using SOLID_principles.SRP;

namespace SOLID_principles
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new SRP.Problem.Recommender();

            var csv = r.ExportToCSV(DummyDB.JOHN);

            string expected = "Saving Private Ryan,Spielberg,War";

            Console.WriteLine(expected);
            Console.WriteLine(csv);
        }
    }
}
