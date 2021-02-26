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
        public abstract double Weigh { get; }
        public abstract double Growth { get; }
        public abstract string Name { get; }
        public abstract Country HomeCountry { get; }

        public abstract DateTime DateArrival { get; }

        public abstract int LifeTime { get; }
        public abstract int Age { get; }
    }
}
