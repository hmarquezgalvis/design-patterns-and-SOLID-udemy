using System;
namespace SOLID_principles.SRP
{
    public class Movie
    {
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Director { get; set; }

        public override string ToString()
        {
            return $"Movie [title={Title}, gender={Gender}, director={Director}]";
        }
    }
}
