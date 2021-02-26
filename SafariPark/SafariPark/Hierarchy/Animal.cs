using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Hierarchy.Enums;

namespace SafariPark.Hierarchy
{
    public abstract class Animal
    {
        public abstract double Weigh { get; set; }
        public abstract double Growth { get; set; }
        public abstract string Name { get; set; }
        public abstract Country HomeCountry { get; set; }

        public abstract DateTime DateArrival { get; set; }

        public abstract TimeSpan LifeTime { get; set; }
        public abstract int Age { get; set; }
    }
}
